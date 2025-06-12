using System.Collections;
using KayphoonStudio;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class VotingOrderManager : KS_Singleton<VotingOrderManager>
{
    public AI_Voting_Base[] aiVotingBases;

    [Header("Timing")]
    public float votingDelay = 0.5f;
    public float randomVoteDelay = 0.5f;

    public TMP_Text currentVotingMemberText;

    [ContextMenu("Find All Voting Base")]
    void FindAllVotingBase()
    {
        // find all AI Voting Bases in the scene
        aiVotingBases = FindObjectsByType<AI_Voting_Base>(FindObjectsSortMode.None);
    }

    public void StartVotingProcess()
    {
        if (aiVotingBases == null || aiVotingBases.Length == 0)
        {
            Debug.LogError("AI Voting Bases are not assigned!");
            return;
        }

        StartCoroutine(VotingProcess());
    }

    IEnumerator VotingProcess()
    {
        yield return new WaitForSeconds(votingDelay);


        foreach (var aiVotingBase in aiVotingBases)
        {
            if (currentVotingMemberText != null)
            {
                currentVotingMemberText.text = $"{aiVotingBase.bikeMemberUI.selfInfo.agentName} is voting...";
            }

            if (aiVotingBase == null)
            {
                Debug.LogError("AI Voting Base is null!");
                continue;
            }

            if (!aiVotingBase.gameObject.activeSelf || aiVotingBase.selfInfo.isDead)
            {
                continue;
            }

            // skip human turn (human's vote is handled elsewhere)
            if (aiVotingBase.isPlayer)
            {
                continue;
            }

            // highlight the current agent
            aiVotingBase.GetComponent<KS_SimpleHighlight>().Highlight(true);

            aiVotingBase.Vote((vote) =>
            {
                // calls the chatting room to vote
                ChattingRoom.Instance.AddDialogue(vote.from, vote.to, vote.reason);
            });

            yield return new WaitForSeconds(votingDelay + Random.Range(0, randomVoteDelay));

            // unhighlight the current agent
            aiVotingBase.GetComponent<KS_SimpleHighlight>().Highlight(false);
        }

        if (currentVotingMemberText != null)
        {
            currentVotingMemberText.gameObject.SetActive(false);
        }

        // check which agent has the most votes
        Dictionary<AgentInfo, int> votedAgentsCount = new();
        foreach (var aiVotingBase in aiVotingBases)
        {
            if (aiVotingBase == null)
            {
                Debug.LogError("AI Voting Base is null!");
                continue;
            }

            if (!votedAgentsCount.ContainsKey(aiVotingBase.selfInfo))
            {
                votedAgentsCount[aiVotingBase.selfInfo] = 0;
            }

            votedAgentsCount[aiVotingBase.selfInfo] += aiVotingBase.voteCount;
        }

        // find the agent with the most votes
        AgentInfo votedAgent = null;
        int maxVotes = 0;
        foreach (var kvp in votedAgentsCount)
        {
            if (kvp.Value > maxVotes)
            {
                maxVotes = kvp.Value;
                votedAgent = kvp.Key;
            }
        }

        KS_NotificationCenter.DispatchEvent(NKeys.OnAgentVoteSequenceFinished, votedAgent);
    }
}
