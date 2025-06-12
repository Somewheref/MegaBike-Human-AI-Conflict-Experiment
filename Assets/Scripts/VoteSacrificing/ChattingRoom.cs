using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;
using KayphoonStudio;

public class ChattingRoom : KS_Singleton<ChattingRoom>
{
    [Header("Chatting Channel")]
    public Transform channelParent;
    public GameObject dialoguePrefab;

    [Header("Fading In")]
    public CanvasGroup canvasGroup;
    public Volume ppVolume;

    [Header("Voting")]
    public VotingOrderManager votingOrderManager;


    public Dictionary<AgentInfo, AgentInfo> votedAgents = new();
    public Dictionary<AgentInfo, int> votedAgentsCount = new();
    public List<VotingInfo> votingInfos = new();

    public void ShowPage()
    {
        gameObject.SetActive(true);
        ppVolume.weight = 0;
        DOTween.To(() => ppVolume.weight, x => ppVolume.weight = x, 1, 0.5f);
        canvasGroup.alpha = 0;
        canvasGroup.KS_FadeIn(0.5f);

        // initialize the voted agents count
        votedAgentsCount.Clear();
        foreach (var agent in PlayerDataStorer.Instance.GetAllAgentDataInfo())
        {
            votedAgentsCount[agent] = 0;
        }

        // start the voting process
        votingOrderManager.StartVotingProcess();
    }

    public void AddDialogue(AgentInfo from, AgentInfo to, string reason, float delay = 0.5f)
    {
        KS_Timer.DelayedAction(delay, () =>
        {
            ImmediatelyAddDialogue(from, to, reason);
        });
    }
    
    public void ImmediatelyAddDialogue(AgentInfo from, AgentInfo to, string reason)
    {
        KS_NotificationCenter.DispatchEvent(NKeys.OnAgentReceivedVote, to);
        
        if (from == null)
        {
            KS_Logger.LogError("From agent is null!");
            return;
        }
        if (to == null)
        {
            KS_Logger.LogError("To agent is null!");
            return;
        }

        else
        {
            KS_Logger.Log("From: " + from.agentName + " To: " + to.agentName);
        }

        if (votedAgents.ContainsKey(from))
        {
            votedAgents[from] = to;
        }
        else
        {
            votedAgents.Add(from, to);
        }

        GameObject dialogueObj = Instantiate(dialoguePrefab, channelParent);
        ChatDialogueObj chatDialogueObj = dialogueObj.GetComponent<ChatDialogueObj>();
        chatDialogueObj.agentInfo = from;
        chatDialogueObj.SetInfo(from, to, reason);

        // Add the voting info to the list
        votingInfos.Add(new VotingInfo
        {
            from = from,
            to = to,
            reason = reason
        });
    }
}


