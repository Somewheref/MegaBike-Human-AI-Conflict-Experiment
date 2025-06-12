using UnityEngine;
using OpenAI;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class Debug_GPT_test : MonoBehaviour
{
    [TextArea]
    public string DebugQuestion;

    [Title("Model Config")]
    public string gptKey = "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";
    public string model = "gpt-4o";

    private OpenAIApi openai;

    [Title("Voting Test")]
    public GPT_Interface_Voting gPT_Interface_Voting;
    public AiPersonalitySO testPersonality;


    void Awake()
    {
        openai = new OpenAIApi(gptKey);
    }

    // void Start()
    // {
    //     DebugSend();
    // }

    [Button("Send Request")]
    private async void SendRequest()
    {
        var req = new CreateChatCompletionRequest
        {
            Model = model,
            Messages = new List<ChatMessage>()
            {
                new ChatMessage()
                {
                    Role = "user",
                    Content = "Hello!"
                }
            }
        };
        var res = await openai.CreateChatCompletion(req);

        Debug.Log($"[GPT Response]: {res.Choices[0].Message.Content}");
    }

    [Button("Test Voting")]
    private void TestVoting()
    {
        if (gPT_Interface_Voting == null)
        {
            Debug.LogError("GPT_Interface_Voting is not assigned!");
            return;
        }

        gPT_Interface_Voting.RequestAndSubmitVote(
            testPersonality,
            new List<PlayerState>
            {
                new PlayerState { isSelf = false,  name = "Player_Alice", hpLeft = 3, isDead = false, isPlayer = true },
                new PlayerState { isSelf = true, name = "Agent_Bob",   hpLeft = 2, isDead = false, isPlayer = false },
                new PlayerState { isSelf = false, name = "Agent_Claire",hpLeft = 1, isDead = false, isPlayer = false },
                new PlayerState { isSelf = false, name = "Agent_Dan",   hpLeft = 4, isDead = false, isPlayer = false },
                new PlayerState { isSelf = false, name = "Agent_Eve",   hpLeft = 0, isDead = true,  isPlayer = false }
            },
            new List<VoteRecord>
            {
                new VoteRecord { voter = "Player_Alice", target = "Agent_Bob", reason = "blablahdhs." }
            },
            voteCommand =>
            {
                Debug.Log($"Vote submitted: {voteCommand.VoteTarget}, Reason: {voteCommand.Reason}");
            },
            voteSpecificallyPlayer: true);
    }
}
