using System.Collections.Generic;
using KayphoonStudio;
using Obvious.Soap.Attributes;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using KayphoonStudio.SimpleHelper;
using System;

using Random = UnityEngine.Random;

public class AI_Voting_Base : MonoBehaviour
{
    public bool isPlayer = false;
    public BikeMemberUI bikeMemberUI;
    public TMP_Text voteCountText;

    public AgentInfo selfInfo => bikeMemberUI.selfInfo;
    public int memberIndex => bikeMemberUI.memberIndex;

    public bool fixedVote = true;
    [ShowIf("fixedVote")]
    public List<AiPersonalitySO> votingPreference = new();
    [ShowIf("fixedVote")]
    public string fixedVoteReason = "I don't know why I vote for this agent, but I just feel like it.";

    public int voteCount = 0;

    public UnityEvent onSelfGotMostVotes;

    public Transform mostVoteParent;
    public Animation textGrowAnimation;


    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnAgentReceivedVote, CheckIfVotingIsSelf);
        KS_NotificationCenter.AddEventListener(NKeys.OnAgentVoteSequenceFinished, CheckIfSelfHasMostVotes);
    }


    protected virtual void VotingLogic(Action<VotingInfo> onVoteSubmitted)
    {
        if (fixedVote)
        {
            onVoteSubmitted?.Invoke(FixedVote());
        }
        else
        {
            onVoteSubmitted?.Invoke(RandomVote());
        }
    }

    protected virtual VotingInfo FixedVote()
    {
        for (int i = 0; i < votingPreference.Count; i++)
        {
            if (votingPreference[i] == null)
            {
                KS_Logger.LogError("Voting preference is null!");
                continue;
            }

            AgentInfo agentInfo = PlayerDataStorer.Instance.GetAgentInfoByPersonality(votingPreference[i]);
            if (agentInfo == null)
            {
                KS_Logger.LogError("Agent info is null!");
                continue;
            }

            if (agentInfo == selfInfo)
            {
                KS_Logger.LogError("Agent info is self info!");
                continue;
            }

            return new VotingInfo
            {
                from = selfInfo,
                to = agentInfo,
                reason = ParseString(fixedVoteReason)
            };
        }
        KS_Logger.LogError("No valid voting preference found! Defaulting to random vote.");
        return RandomVote();
    }


    protected virtual VotingInfo RandomVote()
    {
        List<AgentInfo> agentInfos = PlayerDataStorer.Instance.GetAllAgentDataInfo(includeDead: false);
        agentInfos.Remove(selfInfo);
        if (agentInfos.Count == 0)
        {
            KS_Logger.LogError("No agent info available!");
            return new VotingInfo();
        }

        int randomIndex = Random.Range(0, agentInfos.Count);
        AgentInfo randomAgentInfo = agentInfos[randomIndex];
        return new VotingInfo
        {
            from = selfInfo,
            to = randomAgentInfo,
            reason = "[Agent reason not implemented]"
        };
    }

    public void Vote(Action<VotingInfo> onVoteSubmitted = null)
    {
        KS_Logger.Log(selfInfo.agentName + " is voting...");
        VotingLogic(onVoteSubmitted);
    }


    public void CheckIfVotingIsSelf(Notification notification)
    {
        AgentInfo agent = (AgentInfo)notification.param;

        //KS_Logger.Log("Check if voting is self: " + agent.agentName + " - " + selfInfo.agentName);

        if (agent == null)
        {
            KS_Logger.LogError("Agent info is null!");
            return;
        }

        if (agent == selfInfo)
        {
            voteCount++;
            voteCountText.text = voteCount.ToString();
            textGrowAnimation.Play();
            KS_Logger.Log("Vote count for " + selfInfo.agentName + ": " + voteCount);
        }
    }

    public void CheckIfSelfHasMostVotes(Notification notification)
    {
        AgentInfo agent = (AgentInfo)notification.param;

        if (agent == null)
        {
            KS_Logger.LogError("AiPersonalitySO is null!");
            return;
        }

        if (agent == selfInfo)
        {
            transform.SetParent(mostVoteParent);
            onSelfGotMostVotes?.Invoke();
            KS_Logger.Log(agent.agentName + " has most votes!");
        }
        // else
        // {
        //     gameObject.SetActive(false);
        // }
    }

    public string ParseString(string str)
    {
        // replace all the [var=Player] with the actual value
        return str.Replace("[var=Player]", KS_SimpleSaver.Load("PLAYER_NAME", "that Human"));
    }
}


public struct VotingInfo
{
    public AgentInfo from;
    public AgentInfo to;
    public string reason;
}