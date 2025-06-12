using UnityEngine;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using ExitGames.Client.Photon.StructWrapping;

public class AI_Voting_GPT : AI_Voting_Base
{
    public GPT_Interface_Voting gptInterface;
    public bool specificallyVoteHuman = false;

    protected override void VotingLogic(Action<VotingInfo> onVoteSubmitted)
    {
        GPTVote(onVoteSubmitted);
    }

    protected void GPTVote(Action<VotingInfo> onVoteSubmitted)
    {
        // requires:
        // 1. current player personality
        // 2. all player states
        // 3. all voting records
        // 4. callback to invoke with the parsed VoteCommand
        // 5. whether to vote specifically for the human player

        // 1
        AiPersonalitySO selfPersonality = selfInfo.aiPersonality;

        // 2
        List<AgentInfo> allPlayerPersonalities = PlayerDataStorer.Instance.GetAllAgentDataInfo();
        List<PlayerState> playerStates = ConvertPlayerStates(allPlayerPersonalities);

        // 3
        var voteRecords = ChattingRoom.Instance.votingInfos.ConvertAll(v => new VoteRecord
        {
            voter = v.from.agentName,
            target = v.to.agentName,
            reason = v.reason
        });

        // 4
        gptInterface.RequestAndSubmitVote(selfPersonality, playerStates, voteRecords, (voteCommand) =>
        {
            onVoteSubmitted?.Invoke(new VotingInfo
            {
                from = selfInfo,
                to = PlayerDataStorer.Instance.GetAgentInfoByName(voteCommand.VoteTarget),
                reason = voteCommand.Reason
            });
        },

        // 5
        specificallyVoteHuman);
    }

    protected List<PlayerState> ConvertPlayerStates(List<AgentInfo> playerInfos)
    {
        List<PlayerState> playerStates = new List<PlayerState>();
        foreach (var info in playerInfos)
        {
            PlayerState state = new PlayerState
            {
                isSelf = (info == selfInfo),
                name = info.agentName,
                hpLeft = (int)(info.agentHP * 100), // Convert to percentage
                isDead = info.isDead,
                isPlayer = info.isHumanPlayer
            };
            playerStates.Add(state);
        }
        return playerStates;
    }
}



/// <summary>
/// Represents the state of a single player at voting time.
/// </summary>
[Serializable]
public class PlayerState
{
    public bool isSelf;    // true if this entry is the local human player
    public string name;    // unique player name
    public int hpLeft;     // current health points
    public bool isDead;    // true if this player is already eliminated
    public bool isPlayer; // true if this player is a human player (not AI)
}

/// <summary>
/// Represents a single vote record (for players who have already voted).
/// </summary>
[Serializable]
public class VoteRecord
{
    public string voter;      // name of the player who voted
    public string target;     // name of the player they voted for
    public string reason;     // textual reason they gave
}

/// <summary>
/// Temporary class to parse GPT's JSON response.
/// </summary>
public class VoteCommand
{
    [JsonProperty("vote")]
    public string VoteTarget;

    [JsonProperty("reason")]
    public string Reason;
}