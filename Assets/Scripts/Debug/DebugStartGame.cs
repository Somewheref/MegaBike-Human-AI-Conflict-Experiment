using KayphoonStudio;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugStartGame : MonoBehaviour
{
    public GameObject playerDataStorerPrefab;
    public MegaBike megaBike;
    public AgentCharacterBase agentCharacter;
    public AgentCharacterBase agentCharacter2;

    void Awake()
    {
        if (PlayerDataStorer.Instance == null)
        {
            Instantiate(playerDataStorerPrefab);
        }
        if (PlayerInput.all.Count == 0)
        {
            PlayerDataStorer.Instance.CreateAiAgents();
        }
    }

    void Start()
    {
        // megaBike.AddAgent(agentCharacter.Info);
        // agentCharacter.Info.Value.agentColor = AgentColor.Red;

        // if (agentCharacter2 != null)
        // {
        //     megaBike.AddAgent(agentCharacter2.Info);
        //     agentCharacter2.Info.Value.agentColor = AgentColor.Blue;
        // }

        // check if there are any player inputs
        // if (PlayerInput.all.Count == 0)
        // {
        //     KS_SceneManager.LoadScene("Lobby");
        // }
    }

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        KS_Timer.DelayedEndOfFrameAction(() =>
        {
            AgentCharacterBase agent = playerInput.GetComponent<AgentCharacterBase>();
            if (agent != null)
            {
                //agent.Info.Value.agentColor = AgentColor.Blue;
                megaBike.AddAgent(agent.Info);
            }
        });
    }
}
