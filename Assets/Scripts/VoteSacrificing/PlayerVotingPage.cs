using System.Collections.Generic;
using KayphoonStudio;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerVotingPage : KS_Singleton<PlayerVotingPage>
{
    [Header("Vote Choosing")]
    public CanvasGroup voteChoosingPage;
    public KS_LotteryTextList votingLottery;

    [Header("Vote Reason")]
    public CanvasGroup voteReasonPage;
    public TMP_Text reasonPageTitle;
    public KS_InputFieldLimiter inputChecker;


    public AgentInfo selectedAgentInfo;

    public UnityEvent onVoteAgentSelected;

    private string originalTitleString;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<AgentInfo> agentInfoList = PlayerDataStorer.Instance.GetAllAgentDataInfo(includeDead: true);

        // set lottery text list
        List<KS_LotteryTextList.LotteryOption> nameOptions = new List<KS_LotteryTextList.LotteryOption>();
        foreach (var agentInfo in agentInfoList)
        {
            nameOptions.Add(new KS_LotteryTextList.LotteryOption(agentInfo.agentName, agentInfo.isDead ? 0 : 1));
        }

        votingLottery.SetLotteryOptions(nameOptions);
        KS_Logger.Log("Lottery options set: " + nameOptions.Count);

        KS_Timer.DelayedAction(1f, () =>
        {
            // first find player index
            int playerIndex = PlayerDataStorer.Instance.GetPlayerAgentInfo().bikeSeatIndex - 1;
            // start the lottery
            votingLottery.StartLottery(playerIndex);
            KS_Logger.Log("Lottery started for player index: " + playerIndex);
        });
        
        originalTitleString = reasonPageTitle.text;
    }


    public void PlayerSelectVote(AgentInfo agentInfo)
    {
        if (agentInfo == null)
        {
            KS_Logger.LogError("AgentInfo is null!");
            return;
        }
        
        // TODO
        KS_Logger.Log("Player selected vote for: " + agentInfo.agentName);
        selectedAgentInfo = agentInfo;

        reasonPageTitle.text = string.Format(originalTitleString, agentInfo.agentName);

        onVoteAgentSelected?.Invoke();
    }

    
    public void ValidateAndCastVote()
    {
        bool isValid = inputChecker.Validate();
        if (!isValid) return;
        
        // Player has entered a reason for voting that agent! now close this page
        KS_Logger.Log("Vote casted!");

        string reason = inputChecker.GetText();

        voteChoosingPage.interactable = false;
        voteChoosingPage.KS_FadeOut(0.5f, onFinish : () =>
        {
            // include a delay here
            KS_Timer.DelayedAction(0.5f, () =>
            {
                ChattingRoom.Instance.ShowPage();
                ChattingRoom.Instance.AddDialogue(PlayerDataStorer.Instance.GetPlayerAgentInfo(), selectedAgentInfo, reason);
            });
            
        });
    }
}
