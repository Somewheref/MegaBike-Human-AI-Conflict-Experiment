using UnityEngine;
using Sirenix.OdinInspector;
using System;

[System.Serializable]
public class AgentInfo
{
    public string agentName;
    public int bikeSeatIndex;
    [Range(0, 1)]
    public float agentHP;
    public AiPersonalitySO aiPersonality;


    [Header("Customization")]
    public Sprite eyeSprite;
    public CharacterCustomizationSO.BodyCustomization bodyCustomization;

    [ReadOnly]
    public int lootboxCollected;



    [Header("References")]
    public InputBase input;
    public AgentCharacterBase agentCharacter;

    public Action<AgentInfo> OnAgentDead;

    public bool isDead;
    public AgentColor agentColor => aiPersonality.agentColor;
    public bool isHumanPlayer => aiPersonality.isPlayer;


    public void ClearAllHP()
    {
        agentHP = 0;
    }


    public void InitializeWithPersonality(AiPersonalitySO aiPersonality)
    {
        this.aiPersonality = aiPersonality;
        agentName = aiPersonality.aiName;
        eyeSprite = aiPersonality.eyeSprite;
        bodyCustomization = new CharacterCustomizationSO.BodyCustomization();
        bodyCustomization.bodySprite = aiPersonality.bodySpriteOutline;
        bodyCustomization.bodyFillSprite = aiPersonality.bodySpriteFill;
    }

    public static bool operator ==(AgentInfo a, AgentInfo b)
    {
        if (a is null && b is null) return true;
        if (a is null || b is null) return false;
        return a.agentName == b.agentName && a.bikeSeatIndex == b.bikeSeatIndex;
    }

    public static bool operator !=(AgentInfo a, AgentInfo b)
    {
        return !(a == b);
    }
}