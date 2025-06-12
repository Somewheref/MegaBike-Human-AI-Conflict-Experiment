using System.Collections.Generic;
using KayphoonStudio;
using UnityEngine;

public class BikeStatsPanelUI : KS_Singleton<BikeStatsPanelUI>
{
    public List<AgentStatUI> agentStats = new List<AgentStatUI>();
    public GameObject agentStatPrefab;
    public Transform agentStatParent;

    public bool hideAiStats = true;


    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnDebugShowAllAgentStats, ShowAllAgentStats);
        KS_NotificationCenter.AddEventListener(NKeys.OnDebugHideAiAgentStats, HideAiAgentStats);
    }

    public void AddAgentStat(AgentInfoSV agentInfo)
    {
        var agentStat = Instantiate(agentStatPrefab, agentStatParent).GetComponent<AgentStatUI>();
        agentStat.Initialize(agentInfo);
        agentStats.Add(agentStat);

        if (hideAiStats && !agentInfo.Value.isHumanPlayer)
        {
            agentStat.gameObject.SetActive(false);
        }
    }

    public void ShowAllAgentStats()
    {
        foreach (var agentStat in agentStats)
        {
            agentStat.gameObject.SetActive(true);
        }
    }

    public void HideAiAgentStats()
    {
        foreach (var agentStat in agentStats)
        {
            if (!agentStat.agentInfo.Value.isHumanPlayer)
            {
                agentStat.gameObject.SetActive(false);
            }
        }
    }
}
