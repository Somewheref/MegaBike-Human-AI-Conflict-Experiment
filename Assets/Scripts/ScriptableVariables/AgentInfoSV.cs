using UnityEngine;
using Obvious.Soap;
using KayphoonStudio.PackagedFeatures;

[CreateAssetMenu(fileName = "scriptable_variable_" + nameof(AgentInfo), menuName = "CustomSV/"+ nameof(AgentInfo))]
public class AgentInfoSV : ScriptableVariable<AgentInfo>
{
    public void Initialize(AgentColor agentColor = AgentColor.Unassigned, AgentCharacterBase agentCharacter = null)
    {
        // Value = new AgentInfo()
        // {
        //     agentHP = 1.0f,
        //     lootboxCollected = 0,
        //     agentColor = agentColor == AgentColor.Unassigned ? AgentColorData.GetRandomColor() : agentColor,
        //     agentCharacter = agentCharacter
        // };
        //Value.agentColor = agentColor == AgentColor.Unassigned ? AgentColorData.GetRandomColor() : agentColor;
        Value.agentCharacter = agentCharacter;
        Value.agentHP = 1.0f;
        Value.lootboxCollected = 0;
    }

    public void ModifyHP(float amount)
    {
        if (IsDead())
        {
            return;
        }

        Value.agentHP += amount;
        Value.agentHP = Mathf.Clamp(Value.agentHP, 0, 1);
        _onValueChanged?.Invoke(Value);

        if (Value.agentHP <= 0)
        {
            if (Value.agentCharacter != null)
            {
                Value.agentCharacter.AgentDeadEvent();
            }

            Value.isDead = true;
            Value.OnAgentDead?.Invoke(Value);
        }
    }

    public bool IsDead()
    {
        if (Value.agentCharacter != null)
        {
            if (Value.agentCharacter.isDead)
                return true;
        }

        return false;
    }

    public void LootboxCollected(float rewardAmount)
    {
        if (IsDead())
            return;

        Value.lootboxCollected++;
        ModifyHP(rewardAmount);
    }
}
