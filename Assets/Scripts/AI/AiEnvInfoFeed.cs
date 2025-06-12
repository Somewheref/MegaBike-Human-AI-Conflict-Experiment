using UnityEngine;
using System.Collections.Generic;

public class AiEnvInfoFeed : KS_Singleton<AiEnvInfoFeed>
{
    public Lootbox getNearestLootBoxPosition(Transform transform, AgentColor agentColor = AgentColor.Unassigned)
    {
        List<Lootbox> lootBoxes = LootboxManager.Instance.Lootboxes;
        Lootbox nearestLootBox = null;
        float minDistance = Mathf.Infinity;

        foreach (Lootbox lootBox in lootBoxes)
        {
            if (agentColor != AgentColor.Unassigned && lootBox.boxColor != agentColor)
                continue;
            float distance = Vector3.Distance(transform.position, lootBox.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestLootBox = lootBox;
            }
        }
        return nearestLootBox;
    }
}
