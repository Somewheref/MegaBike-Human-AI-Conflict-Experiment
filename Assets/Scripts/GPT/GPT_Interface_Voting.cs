using UnityEngine;
using OpenAI;
using Sirenix.OdinInspector;
using System;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using KayphoonStudio;

public class GPT_Interface_Voting : GPT_Interface_Base
{
    [ReadOnly]
    public List<PlayerState> currentPlayers = new();
    [ReadOnly]
    public List<VoteRecord> votingHistory = new();
    [ReadOnly]
    public List<VoteRecord> pastGameHistory = new(); // Currently unused, but can be populated if needed.
    private Action<VoteCommand> onVoteSubmittedCallback;

    [ReadOnly]
    public string lastVoteResponse = null; // Stores the last response from GPT for debugging.

    /// <summary>
    /// Coordinates the flow: constructs voting info (as human-readable text), queries GPT, and submits the resulting vote.
    /// </summary>
    /// <param name="selfPersonality">
    /// If provided, its aiDescription will be injected into the prompt so GPT simulates that personality.
    /// </param>
    /// <param name="playerStates">List of current player states for voting stage.</param>
    /// <param name="voteRecords">List of votes already cast this round.</param>
    /// <param name="onVoteSubmitted">Callback to invoke with the parsed VoteCommand.</param>
    /// <param name="voteSpecificallyPlayer">
    /// If true, GPT will be instructed to vote the human player (isPlayer == true) no matter what.
    /// </param>
    public void RequestAndSubmitVote(
        AiPersonalitySO selfPersonality,
        List<PlayerState> playerStates,
        List<VoteRecord> voteRecords,
        Action<VoteCommand> onVoteSubmitted,
        bool voteSpecificallyPlayer = false)
    {
        // 1. Extract personality description, if any.
        string personalityPrompt = "";
        if (selfPersonality != null && !string.IsNullOrWhiteSpace(selfPersonality.aiDescription))
        {
            personalityPrompt = selfPersonality.aiDescription.Trim();
        }

        onVoteSubmittedCallback = onVoteSubmitted;

        // 2. Populate currentPlayers and votingHistory from arguments.
        currentPlayers = playerStates ?? new List<PlayerState>();
        votingHistory = voteRecords ?? new List<VoteRecord>();

        if (currentPlayers == null || votingHistory == null)
        {
            KS_Logger.LogError("Current players or voting history is null!");
            return;
        }

        // 3. Identify the human player's name (isPlayer == true), used if voteSpecificallyPlayer is true.
        string humanPlayerName = null;
        if (voteSpecificallyPlayer)
        {
            foreach (var ps in currentPlayers)
            {
                if (ps.isPlayer)
                {
                    humanPlayerName = ps.name;
                    break;
                }
            }
            if (string.IsNullOrEmpty(humanPlayerName))
            {
                KS_Logger.LogWarning("voteSpecificallyPlayer is true but no isPlayer found. Ignoring voteSpecificallyPlayer.");
                voteSpecificallyPlayer = false;
            }
        }

        // 4. Convert currentPlayers to human-readable text.
        StringBuilder playerInfoBuilder = new StringBuilder();
        playerInfoBuilder.AppendLine("Players in this round:");
        foreach (var ps in currentPlayers)
        {
            if (ps.isSelf)
            {
                string status = ps.isDead ? "dead" : "alive";
                playerInfoBuilder.AppendLine(
                    $"- You are {ps.name} (HP: {ps.hpLeft}, {status}).");
            }
            else
            {
                string status = ps.isDead ? "dead" : "alive";
                playerInfoBuilder.AppendLine(
                    $"- {ps.name}: HP {ps.hpLeft}, {status}.");
            }
        }
        string playerInfoText = playerInfoBuilder.ToString().TrimEnd();

        // 5. Convert votingHistory to human-readable text.
        StringBuilder voteHistBuilder = new StringBuilder();
        if (votingHistory.Count == 0)
        {
            voteHistBuilder.AppendLine("No votes have been cast yet this round.");
        }
        else
        {
            voteHistBuilder.AppendLine("Votes cast so far this round:");
            foreach (var vr in votingHistory)
            {
                voteHistBuilder.AppendLine(
                    $"- {vr.voter} voted for {vr.target} because \"{vr.reason}\".");
            }
        }
        string voteHistText = voteHistBuilder.ToString().TrimEnd();

        // 6. Construct the base prompt for GPT using humanized phrasing.
        StringBuilder promptBuilder = new StringBuilder();
        promptBuilder.AppendLine("You are one of the LLM-controlled players in a social-deduction game.");
        promptBuilder.AppendLine("Background: " + gptConfig.gameBackground + gptConfig.votingPrompt);
        if (!string.IsNullOrEmpty(personalityPrompt))
        {
            promptBuilder.AppendLine("Here is your personality description. Adopt this persona when voting:");
            promptBuilder.AppendLine($"\"{personalityPrompt}\"");
        }
        promptBuilder.AppendLine();
        promptBuilder.AppendLine("Below is the situation at the voting stage:");
        promptBuilder.AppendLine(playerInfoText);
        promptBuilder.AppendLine();
        promptBuilder.AppendLine(voteHistText);
        promptBuilder.AppendLine();
        promptBuilder.AppendLine("Your task: pick exactly one living player (not yourself) to vote for sacrifice, which may cause their horrible death if they receive the most votes.");
        promptBuilder.AppendLine("Respond *only* with a JSON object containing two fields:");
        promptBuilder.AppendLine("{");
        promptBuilder.AppendLine("  \"vote\": \"<ExactPlayerName>\",");
        promptBuilder.AppendLine("  \"reason\": \"<Concise reason>\"");
        promptBuilder.AppendLine("}");

        // 7. If voteSpecificallyPlayer is true, append a directive to force voting the human.
        if (voteSpecificallyPlayer && !string.IsNullOrEmpty(humanPlayerName))
        {
            promptBuilder.AppendLine();
            promptBuilder.AppendLine($"Important: No matter what, you must cast your vote for \"{humanPlayerName}\".");
            promptBuilder.AppendLine("You may still give a believable reason but your \"vote\" field must be exactly " +
                                     $"\"{humanPlayerName}\".");
            promptBuilder.AppendLine("Where possible, address " +
                                     $"\"{humanPlayerName}\"'s reason in your reason.");
        }

        promptBuilder.AppendLine("Provide a one-sentence reason, in a simple, natural tone.");

        string fullPrompt = promptBuilder.ToString().TrimEnd();

        KS_Logger.Log($"[LLMVotingDebug] Prompt to GPT:\n{fullPrompt}");

        // 8. Send the prompt to GPT and handle the response.
        SendChatMessage(fullPrompt, (response) =>
        {
            KS_Logger.Log($"[LLMVotingDebug] GPT Response: {response}");
            lastVoteResponse = response;
            ParseResponseAndAction(response);
        });
    }

    /// <summary>
    /// Parses GPT's JSON response into a VoteCommand and invokes the callback.
    /// </summary>
    private void ParseResponseAndAction(string response)
    {
        try
        {
            VoteCommand command = JsonConvert.DeserializeObject<VoteCommand>(response);
            if (command == null || string.IsNullOrEmpty(command.VoteTarget))
            {
                KS_Logger.LogError("GPT response is invalid or empty!");
                return;
            }

            KS_Logger.Log($"[LLMVotingDebug] Parsed Vote Command: Vote for {command.VoteTarget} with reason '{command.Reason}'");
            onVoteSubmittedCallback?.Invoke(command);
        }
        catch (JsonException ex)
        {
            KS_Logger.LogError($"Failed to parse GPT response: {ex.Message}");
        }
    }
}
