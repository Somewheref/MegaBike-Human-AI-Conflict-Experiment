using UnityEngine;


// the file that contains the AI data
[CreateAssetMenu(fileName = "AiPersonalitySO", menuName = "ScriptableObjects/AiPersonalitySO", order = 1)]
public class AiPersonalitySO : ScriptableObject
{
    [Header("Basic Info")]
    public bool isPlayer = false;
    public string aiName = "AI";
    public string aiDescription = "This is a AI personality.";
    public Sprite eyeSprite;
    public Sprite bodySpriteFill;
    public Sprite bodySpriteOutline;
    public AgentColor agentColor;


    [Header("Movement")]
    [Range(0, 5)]
    public float decisionUpdateInterval = 1f; // how often the AI will update its decision
    [Range(0, 0.99f)]
    public float volatility = 0.5f; // affects randomness. 0: perfectly predictable, 1: completely random
    public float valueLerpSpeed = 5f; // how fast the AI will lerp strength and direction
    [Range(0, 1)]
    public float lazyness = 0.5f;   // general value on the work it will put in
    [Range(0, 1)]
    public float hungerAdditionalLazyness = 0.3f; // the value to add to the lazyness when the agent is at low stamina

    [Range(0, 1)]
    public float determination = 0.25f;  // how much the AI will presist its last target lootbox

    // selfish parameters
    [Range(0, 1)]
    public float selfishness = 0.5f;
    [Range(0, 4)]
    public float selfishWorkMultiplier = 1.5f; // when going to the nearest lootbox with agent color, this is the multiplier for the work done
    [Range(0, 1)]
    public float hugerAdditionalSelfishness = 0.5f; // the value to add to the selfishness when the agent is at low stamina

    // agreeable parameters
    [Range(0, 1)]
    public float agreeable = 0.5f; // how much the AI will help the weakest agent
    [Range(0, 2)]
    public float agreeableMultiplier = 0.5f; // when going to the nearest lootbox with agent color, this is the multiplier for the work done
}
