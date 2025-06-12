using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using KayphoonStudio;


public class PlayerDataStorer : KS_Singleton<PlayerDataStorer>
{
    public AiPersonalitySO playerPersonalitySO;
    public List<AgentInfo> agentInfoList = new List<AgentInfo>();
    public List<AiPersonalitySO> aiPersonalityList;
    public Dictionary<GameObject, AgentInfo> playerAgentInfoDict = new Dictionary<GameObject, AgentInfo>();
    public Dictionary<AiPersonalitySO, AgentInfo> aiPersonalityAgentInfoDict = new Dictionary<AiPersonalitySO, AgentInfo>();
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public List<GameObject> GetPlayerGameobjectList()
    {
        return new List<GameObject>(playerAgentInfoDict.Keys);
    }

    public List<AiPersonalitySO> GetAiPersonalityList()
    {
        return new List<AiPersonalitySO>(aiPersonalityAgentInfoDict.Keys);
    }

    // this will be called by the input manager
    [System.Obsolete()]
    public void OnNewPlayerJoined(PlayerInput input)
    {
        KS_Logger.Log("OnNewPlayerJoined - Player index: " + input.playerIndex);
        // log all current player indexes
        foreach (var agentInfo in agentInfoList)
        {
            KS_Logger.Log("Player index: " + agentInfo.bikeSeatIndex);
        }
        // check if the player index is already in the agentInfoList
        // if (agentInfoList.Find(agentInfo => agentInfo.playerIndex - 1 == input.playerIndex) != null)

        // {
        //     KS_Logger.Log("Player index already in the agentInfoList");
        //     return;
        // }

        //var info = RegisterNewPlayerInLobby(LobbyScene.Instance.OnNewPlayerJoined(input));

        // move the spawned input prefab under itself
        input.transform.parent = transform;
        // input.gameObject.SetActive(false);

        // InputBase inputBase = input.GetComponent<InputBase>();
        // inputBase.enabled = false;
        // info.input = inputBase;

        // playerAgentInfoDict.Add(input.gameObject, info);   
    }

    // this will be called by the lobby scene, and we will already have the ai input base with personality
    public List<AiPersonalitySO> CreateAiAgents()
    {
        foreach (var aiPersonality in aiPersonalityList)
        {
            KS_Logger.Log("OnNewAIPlayerJoined - Ai personality: " + aiPersonality.name);

            var info = RegisterNewPlayerInLobby(aiPersonality);
        }
        
        return aiPersonalityList;
    }

    public AgentInfo GetPlayerAgentInfo()
    {
        // return the first agent info that is not a human player
        foreach (var agentInfo in agentInfoList)
        {
            if (agentInfo == null)
            {
                continue;
            }
            if (agentInfo.isHumanPlayer)
            {
                return agentInfo;
            }
        }
        return null;
    }

    public AgentInfo GetAgentInfoByPersonality(AiPersonalitySO aiPersonality)
    {
        if (aiPersonalityAgentInfoDict.ContainsKey(aiPersonality))
        {
            return aiPersonalityAgentInfoDict[aiPersonality];
        }
        if (aiPersonality == playerPersonalitySO)
        {
            return GetPlayerAgentInfo();
        }
        return null;
    }

    public AgentInfo GetAgentInfoByName(string agentName)
    {
        // check if there are duplicate names
        int count = 0;
        foreach (var agentInfo in agentInfoList)
        {
            if (agentInfo.agentName == agentName)
            {
                count++;
            }
        }
        if (count > 1)
        {
            KS_Logger.LogWarning("Duplicate agent names found: " + agentName + " - Count: " + count);
        }
        
        foreach (var agentInfo in agentInfoList)
        {
            if (agentInfo.agentName == agentName)
            {
                return agentInfo;
            }
        }
        return null;
    }

    public void OnMainSceneStart()
    {
        foreach (var agentInfo in agentInfoList)
        {
            // if (agentInfo.isHumanPlayer)
            // {
            //     agentInfo.input.enabled = true;
            // }
            // else
            // {

            // }
        }
    }

    public List<AgentInfo> GetAllAgentDataInfo(bool includeDead = true)
    {
        if (includeDead)
        {
            return agentInfoList;
        }
        else
        {
            List<AgentInfo> aliveAgentInfoList = new List<AgentInfo>();
            foreach (var agentInfo in agentInfoList)
            {
                if (!agentInfo.isDead)
                {
                    aliveAgentInfoList.Add(agentInfo);
                }
            }
            return aliveAgentInfoList;
        }
    }


    public AgentInfo RegisterNewPlayerInLobby(AiPersonalitySO aiPersonality = null)
    {
        AgentInfo agentInfo = new();
        agentInfo.InitializeWithPersonality(aiPersonality);
        agentInfo.bikeSeatIndex = GetNextAvailablePlayerIndex();

        if (agentInfo.isHumanPlayer)
        {
            // if human, we need to create a new player input object
            PlayerInputManager inputManager = FindObjectsByType<PlayerInputManager>(FindObjectsSortMode.None)[0];
            PlayerInput inputObject = inputManager.JoinPlayer();
            InputBase inputBase = inputObject.GetComponent<InputBase>();
            inputObject.transform.SetParent(transform);

            if (inputBase != null) agentInfo.input = inputBase;
            else KS_Logger.LogError("InputBase not found on player input object");

            playerAgentInfoDict.Add(inputObject.gameObject, agentInfo);
        }
        else if (aiPersonality != null)
        {
            // AI
            aiPersonalityAgentInfoDict.Add(aiPersonality, agentInfo);
        }

        agentInfoList.Add(agentInfo);
        return agentInfo;
    }

    public int GetNextAvailablePlayerIndex()

    {
        int playerIndex = 0;
        foreach (var agentInfo in agentInfoList)
        {
            if (agentInfo.bikeSeatIndex > playerIndex)
            {
                playerIndex = agentInfo.bikeSeatIndex;
            }
        }
        return playerIndex + 1;
    }
    
}
