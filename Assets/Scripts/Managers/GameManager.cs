using UnityEngine;
using KayphoonStudio;
using System.Collections.Generic;
using System.Collections;
public class GameManager : KS_Singleton<GameManager>
{
    public GameObject humanPlayerPrefab;
    public GameObject aiPlayerPrefab;

    public bool IsPaused { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (!PlayerDataStorer.Instance)
            return;
        
        // Human
        PlayerDataStorer.Instance.OnMainSceneStart();
        foreach (KeyValuePair<GameObject, AgentInfo> pair in PlayerDataStorer.Instance.playerAgentInfoDict)
        {
            // unwrap the pair
            GameObject inputGameobject = pair.Key;
            AgentInfo agentInfo = pair.Value;

            GameObject humanPlayer = Instantiate(humanPlayerPrefab);
            humanPlayer.transform.localPosition = Vector3.zero;
            humanPlayer.transform.localScale = Vector3.one;

            // assign the input under the human player
            inputGameobject.transform.parent = humanPlayer.transform;
            inputGameobject.transform.localPosition = Vector3.zero;
            inputGameobject.transform.localScale = Vector3.one;

            AgentCharacterBase agentCharacter = humanPlayer.GetComponent<AgentCharacterBase>();
            // InputBase input = inputGameobject.GetComponent<InputBase>();
            // input.enabled = true;
            agentInfo.input.enabled = true;
            agentCharacter.InitializeInfo(agentInfo, agentColor: AgentColorData.GetRandomColor(FindAnyObjectByType<MegaBike>().GetCurrentColorsOnBike()));
            agentCharacter.Info.Value.agentCharacter = agentCharacter;

            FindAnyObjectByType<MegaBike>().AddAgent(agentCharacter.Info);
        }

        // AI
        foreach (KeyValuePair<AiPersonalitySO, AgentInfo> pair in PlayerDataStorer.Instance.aiPersonalityAgentInfoDict)
        {
            // unwrap the pair
            AiPersonalitySO aiPersonality = pair.Key;
            AgentInfo agentInfo = pair.Value;

            GameObject aiPlayer = Instantiate(aiPlayerPrefab);
            AIPlayerAgent aiPlayerAgent = aiPlayer.GetComponent<AIPlayerAgent>();
            aiPlayer.transform.localPosition = Vector3.zero;
            aiPlayer.transform.localScale = Vector3.one;

            // store the value like player
            AgentCharacterBase agentCharacter = aiPlayer.GetComponent<AgentCharacterBase>();
            // additional input for ai
            InputBase input = aiPlayer.GetComponent<InputBase>();
            input.enabled = true;
            agentInfo.input = input;
            // ai personality
            AiInput aiInput = aiPlayer.GetComponent<AiInput>();
            aiInput.aiPersonality = aiPersonality;
            // init
            agentCharacter.InitializeInfo(agentInfo, agentColor: AgentColorData.GetRandomColor(FindAnyObjectByType<MegaBike>().GetCurrentColorsOnBike()));
            FindAnyObjectByType<MegaBike>().AddAgent(aiPlayerAgent.Info);
        }
    }

    private IEnumerator Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnAgentDead, OnAgentDead);
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeStart, OnOwdiSacrificeStart);
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeEnd, OnOwdiSacrificeEnd);

        yield return new WaitForSeconds(0.5f);

        foreach (var agent in PlayerDataStorer.Instance.agentInfoList)
        {
            agent.agentCharacter.agentGFX.Initialize(agent);
        }
    }

    public void OnAgentDead(Notification notification)
    {
        // check if all agents are dead (except one that is alive)
        int aliveAgents = 0;
        AgentInfo winningAgent = null;
        foreach (var agent in PlayerDataStorer.Instance.agentInfoList)
        {
            if (agent.agentCharacter != null && !agent.agentCharacter.isDead)
            {
                aliveAgents++;
                winningAgent = agent;
            }
        }
        
        if (aliveAgents <= 1)
        {
            // game over
            if (winningAgent == null)
            {
                KS_Logger.LogError("No winning agent found");
            }
            else
            {
                KS_Logger.Log($"Game over, {winningAgent.agentCharacter.Info.name} wins");
            }
            KS_NotificationCenter.DispatchEvent(NKeys.OnSceneToGameOver, winningAgent);
        }

        // if player is dead, then pause the game
        if (PlayerDataStorer.Instance.GetPlayerAgentInfo().isDead)
        {
            KS_NotificationCenter.DispatchEvent(NKeys.OnSceneToGameOver, winningAgent);
        }

        KS_Logger.Log($"Alive agents: {aliveAgents}");
    }

    public void PauseGame()
    {
        IsPaused = true;
    }

    public void ResumeGame()
    {
        IsPaused = false;
    }

    public void OnOwdiSacrificeStart(Notification notification)
    {
        PauseGame();
        FindAnyObjectByType<BikeMovement>().SetFreezeState(true);   // patch fix here
    }

    public void OnOwdiSacrificeEnd(Notification notification)
    {
        ResumeGame();
        FindAnyObjectByType<BikeMovement>().SetFreezeState(false);
    }
}
