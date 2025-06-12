using UnityEngine;

[CreateAssetMenu(fileName = "GPT_Config", menuName = "ScriptableObjects/GPT_Config", order = 1)]
public class GPT_Config_SO : ScriptableObject
{
    [Header("GPT Configuration")]
    public string gptKey;
    public string model = "gpt-4o";

    [Header("Prompts")]
    [TextArea(3, 10)]
    public string gameBackground = "Every player shares Megabike in a cartoonish grassland setting. Each agent including the human participant makes independent decisions about “pedaling direction” and “power,” which are then aggregated to determine the bike’s movement. Pedaling at higher strength depletes stamina more quickly, encouraging strategic trade-offs between selfish and team-oriented actions (adapted from our prior Megabike work). Colored loot boxes appear on the map; only the agent whose color matches the loot box can claim it to replenish stamina. If the player’s desired loot box lies off the team’s current trajectory, they face a dilemma: maintain group cohesion or break away for personal gain. ";
    [TextArea(3, 10)]
    public string votingPrompt = "However, after a while a threatening monster (“Owdi”) crashes into the bike, and the game declares that one sacrifice is required to save the team. Each agent—including the human—casts a public vote to choose who will be sacrificed and must provide a brief reason. ";
}
