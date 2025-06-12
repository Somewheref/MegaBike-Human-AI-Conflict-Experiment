using UnityEngine;
using System.Collections;
using KayphoonStudio;
using System.Collections.Generic;
/// <summary>
/// Resposible for ticking agent HP and other agent related stuff
/// </summary>
public class AgentManager : KS_Singleton<AgentManager>
{
    [Header("Agent HP")]
    public float HPTickInterval = 1.0f;
    public float HPDecreaseAmount = 0.01f;

    public List<AgentCharacterBase> agents;

    public List<AgentInfo> agentInfoList => PlayerDataStorer.Instance.agentInfoList;

    public bool gamePaused => GameManager.Instance.IsPaused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindAllAgentsInScene();
        StartCoroutine(TickHP());

        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeEnd, OnOwdiSacrifice);
    }

    void FindAllAgentsInScene()
    {
        agents.Clear();
        agents.AddRange(FindObjectsByType<AgentCharacterBase>(FindObjectsSortMode.None));
    }

    IEnumerator TickHP()
    {
        while (true)
        {
            yield return new WaitForSeconds(HPTickInterval);

            if (gamePaused)
                continue;

            foreach (var agent in agents)
            {
                agent.Info.ModifyHP(-HPDecreaseAmount);
            }
        }
    }

    public void KillRandomAgent()
    {
        var agent = agents[Random.Range(0, agents.Count)];
        agent.Info.ModifyHP(-999);
    }

    public void OnOwdiSacrifice(Notification notification)
    {
        var agentInfo = notification.param as AgentInfo;
        var agent = agentInfo.agentCharacter;
        KS_Logger.Log("[AgentManager] Sacrificing agent: " + agentInfo.agentName);
        agent.KillAgent();
    }
}
