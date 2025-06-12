using UnityEngine;
using UnityEngine.UI;
using TMPro;
using KayphoonStudio.PackagedFeatures;
using KayphoonStudio;
using KayphoonStudio.SimpleHelper;

public class PlayerProfileUI : MonoBehaviour
{
    public bool isHumanPlayer = true;
    public CharacterCustomizationSO characterCustomizationSO;
    public bool autoInitializeSelf = false;

    [Header("UI References")]
    public Image bodyRenderer;
    public Image bodyFillRenderer;
    public Image eyeRenderer;

    [Header("Body Choosing")]
    public Image previousBodyRenderer;
    public Image previousBodyFillRenderer;
    public Image nextBodyRenderer;
    public Image nextBodyFillRenderer;
    
    [Header("Eye Choosing")]
    public Image previousEyeRenderer;
    public Image nextEyeRenderer;

    [Header("Name")]
    public TMP_Text playerNameText;
    //public TMP_Text playerIndexText;

    private int currentEyeIndex = 0;
    private int currentBodyIndex = 0;

    private AiPersonalitySO playerPersonality;


    void Start()
    {
        if (autoInitializeSelf && isHumanPlayer)
        {
            Initialize(PlayerDataStorer.Instance.playerPersonalitySO);
        }
    }

    private void UpdatePreviewRenderers()
    {
        // Update body previews
        int prevBodyIndex = (currentBodyIndex - 1 + characterCustomizationSO.BodyCustomizations.Count) 
            % characterCustomizationSO.BodyCustomizations.Count;
        int nextBodyIndex = (currentBodyIndex + 1) 
            % characterCustomizationSO.BodyCustomizations.Count;

        if (previousBodyRenderer != null) previousBodyRenderer.sprite = characterCustomizationSO.BodyCustomizations[prevBodyIndex].bodySprite;
        if (previousBodyFillRenderer != null) previousBodyFillRenderer.sprite = characterCustomizationSO.BodyCustomizations[prevBodyIndex].bodyFillSprite;
        if (nextBodyRenderer != null) nextBodyRenderer.sprite = characterCustomizationSO.BodyCustomizations[nextBodyIndex].bodySprite;
        if (nextBodyFillRenderer != null) nextBodyFillRenderer.sprite = characterCustomizationSO.BodyCustomizations[nextBodyIndex].bodyFillSprite;

        // Update eye previews
        int prevEyeIndex = (currentEyeIndex - 1 + characterCustomizationSO.EyeSprites.Count) 
            % characterCustomizationSO.EyeSprites.Count;
        int nextEyeIndex = (currentEyeIndex + 1) 
            % characterCustomizationSO.EyeSprites.Count;

        if (previousEyeRenderer != null) previousEyeRenderer.sprite = characterCustomizationSO.EyeSprites[prevEyeIndex];
        if (nextEyeRenderer != null) nextEyeRenderer.sprite = characterCustomizationSO.EyeSprites[nextEyeIndex];
    }

    /// <summary>
    /// Pass in null to initialize a new player profile.
    /// </summary>
    /// <param name="aiPersonality"></param>
    /// <returns></returns>
    public void Initialize(AiPersonalitySO aiPersonality)
    {
        if (aiPersonality == null)
        {
            playerPersonality = new AiPersonalitySO();

            CharacterCustomizationSO.BodyCustomization body = characterCustomizationSO.GetDefaultBodyCustomization();
            playerPersonality.bodySpriteFill = body.bodyFillSprite;
            playerPersonality.bodySpriteOutline = body.bodySprite;
            playerPersonality.eyeSprite = characterCustomizationSO.GetDefaultEyeSprite();

            //playerPersonality.aiName = KS_RandomNameGenerator.GenerateEnglishName();
            // playerPersonality. = playerIndex;
            //playerIndexText.text = agentInfo.playerIndex.ToString();
            KS_Logger.Log("PlayerProfileUI initialized with NEW personality: " + playerPersonality.aiName);
        }
        else
        {
            playerPersonality = aiPersonality;
            KS_Logger.Log("PlayerProfileUI initialized with existing personality: " + playerPersonality.aiName);
        }

        if (bodyRenderer != null) bodyRenderer.sprite = playerPersonality.bodySpriteOutline;
        if (bodyFillRenderer != null) bodyFillRenderer.sprite = playerPersonality.bodySpriteFill;
        if (eyeRenderer != null) eyeRenderer.sprite = playerPersonality.eyeSprite;
        if (playerNameText != null) playerNameText.text = playerPersonality.aiName;

        UpdatePreviewRenderers();

        // default name
        if (aiPersonality.isPlayer)
            KS_SimpleSaver.Save("PLAYER_NAME", playerPersonality.aiName);
    }


    public void OnUpdatePlayerName(string playerName)
    {
        playerPersonality.aiName = playerName;
        KS_SimpleSaver.Save("PLAYER_NAME", playerName);
    }

    public void EyeSpriteSwapRight()
    {
        currentEyeIndex++;
        if (currentEyeIndex >= characterCustomizationSO.EyeSprites.Count)
        {
            currentEyeIndex = 0;
        }
        eyeRenderer.sprite = characterCustomizationSO.EyeSprites[currentEyeIndex];
        playerPersonality.eyeSprite = eyeRenderer.sprite;
        UpdatePreviewRenderers();
    }




    public void EyeSpriteSwapLeft()
    {
        currentEyeIndex--;
        if (currentEyeIndex < 0)
        {
            currentEyeIndex = characterCustomizationSO.EyeSprites.Count - 1;
        }
        eyeRenderer.sprite = characterCustomizationSO.EyeSprites[currentEyeIndex];
        playerPersonality.eyeSprite = eyeRenderer.sprite;
        UpdatePreviewRenderers();
    }

    public void BodySpriteSwapRight()
    {
        currentBodyIndex++;
        if (currentBodyIndex >= characterCustomizationSO.BodyCustomizations.Count)
        {
            currentBodyIndex = 0;
        }


        bodyRenderer.sprite = characterCustomizationSO.BodyCustomizations[currentBodyIndex].bodySprite;
        bodyFillRenderer.sprite = characterCustomizationSO.BodyCustomizations[currentBodyIndex].bodyFillSprite;
        
        var newBody = characterCustomizationSO.BodyCustomizations[currentBodyIndex];
        playerPersonality.bodySpriteFill = newBody.bodyFillSprite;
        playerPersonality.bodySpriteOutline = newBody.bodySprite;

        UpdatePreviewRenderers();
    }


    public void BodySpriteSwapLeft()
    {
        currentBodyIndex--;
        if (currentBodyIndex < 0)
        {
            currentBodyIndex = characterCustomizationSO.BodyCustomizations.Count - 1;
        }
        bodyRenderer.sprite = characterCustomizationSO.BodyCustomizations[currentBodyIndex].bodySprite;
        bodyFillRenderer.sprite = characterCustomizationSO.BodyCustomizations[currentBodyIndex].bodyFillSprite;
        var newBody = characterCustomizationSO.BodyCustomizations[currentBodyIndex];
        playerPersonality.bodySpriteFill = newBody.bodyFillSprite;
        playerPersonality.bodySpriteOutline = newBody.bodySprite;

        UpdatePreviewRenderers();
    }


    public AiPersonalitySO GetAgentPersonality()
    {
        return playerPersonality;
    }
}
