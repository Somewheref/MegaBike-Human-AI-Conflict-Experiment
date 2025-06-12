using UnityEngine;
using KayphoonStudio;
using System.Collections.Generic;
using KayphoonStudio.EditorHelpers;

public class Lootbox : MonoBehaviour, IAgentColor
{
    public AgentColor boxColor;
    public bool randomColor;
    public float rewardAmount;

    public float persistTime = 10f;
    public float randomPersistTime = 20f;

    void OnEnable()
    {
        if (randomColor)
        {
            boxColor = AgentColorData.GetRandomColor();
        }

        // TODO: add a exit animation
        Destroy(gameObject, persistTime + Random.Range(0, randomPersistTime));

        // TODO: add a entrance animation
    }

    public void Open(MegaBike megaBike, ref List<AgentInfoSV> agents)
    {
        // compare the color of the lootbox with the color of the agents
        foreach (var agent in agents)
        {
            if (agent.Value.agentColor == boxColor)
            {
                agent.LootboxCollected(rewardAmount);
            }
        }

        KS_NotificationCenter.DispatchEvent(NKeys.OnLootboxOpened, this);

        // destroy the lootbox
        Destroy(gameObject);
    }

    public AgentColor GetAgentColor()
    {
        return boxColor;
    }

    public void OnDestroy()
    {
        KS_NotificationCenter.DispatchEvent(NKeys.OnLootboxDestroyed, this);
    }
}
