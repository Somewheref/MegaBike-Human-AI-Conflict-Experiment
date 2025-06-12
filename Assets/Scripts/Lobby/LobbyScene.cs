using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using KayphoonStudio;
using UnityEngine.Events;

public class LobbyScene : KS_Singleton<LobbyScene>
{
    public AiPersonalitySO playerPersonalitySO => PlayerDataStorer.Instance.playerPersonalitySO;
    public GameObject PlayerCardPrefab;
    public Transform PlayerCardParent;
    public GameObject AICardPrefab;

    public List<GameObject> generatedPlayerCards = new List<GameObject>();
    public UnityEvent onAICreated;


    public int maxPlayerCount = 8;

    public bool autoFillWithAI = true;

    public int currentPlayerCount => FindObjectsByType<PlayerProfileUI>(FindObjectsSortMode.None).Length;

    private PlayerProfileUI mainPlayer;



    public void InitLobby(PlayerProfileUI mainPlayer = null)
    {
        this.mainPlayer = mainPlayer;

        if (mainPlayer != null)
        {
            OnNewPlayerJoined(playerPersonalitySO);
            PlayerDataStorer.Instance.RegisterNewPlayerInLobby(playerPersonalitySO);// this will create player input object and stores it
        }

        if (autoFillWithAI)
        {
            AutoFillWithAI();
        }
    }

    public GameObject OnNewPlayerJoined(AiPersonalitySO agentPersonality)
    {
        GameObject playerCard = CreateEmptyAiCard();
        PlayerProfileUI playerProfileUI = playerCard.GetComponent<PlayerProfileUI>();
        if (playerProfileUI != null)
        {
            playerProfileUI.Initialize(agentPersonality);
        }
        else
        {
            KS_Logger.LogError("PlayerProfileUI not found on player card");
        }
        return playerCard;
    }

    public GameObject CreateEmptyAiCard()
    {
        GameObject aiCard = Instantiate(AICardPrefab);
        aiCard.transform.parent = PlayerCardParent;
        aiCard.transform.localPosition = new Vector3(0, 0, 0);
        aiCard.transform.localScale = 0.8f * Vector3.one;
        generatedPlayerCards.Add(aiCard);
        return aiCard;
    }

    public void AutoFillWithAI()
    {
        if (autoFillWithAI)
        {
            // register all AI in player data storer
            PlayerDataStorer.Instance.CreateAiAgents();

            foreach (var agentPersonality in PlayerDataStorer.Instance.aiPersonalityList)
            {
                GameObject newAiCard = CreateEmptyAiCard();

                // initialize AI gfx
                PlayerProfileUI aiProfileUI = newAiCard.GetComponent<PlayerProfileUI>();
                if (aiProfileUI != null)
                {
                    var personalityCopy = agentPersonality;
                    aiProfileUI.Initialize(personalityCopy);
                }
            }

            onAICreated?.Invoke();
        }
    }

    // patch fix
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         AgentInfo agentInfo = new AgentInfo();
    //         // agentInfo.isHumanPlayer = true;
    //         agentInfo.bikeSeatIndex = PlayerDataStorer.Instance.GetNextAvailablePlayerIndex();
    //         agentInfo.agentName = "Controller Player";
    //         agentInfo.bodyCustomization = this.mainPlayer.characterCustomizationSO.GetRandomBodyCustomization();
    //         agentInfo.eyeSprite = this.mainPlayer.characterCustomizationSO.GetRandomEyeSprite();
    //         OnNewPlayerJoined(agentInfo);
    //         PlayerDataStorer.Instance.RegisterNewPlayerInLobby(agentInfo);
    //     }
    // }
}
