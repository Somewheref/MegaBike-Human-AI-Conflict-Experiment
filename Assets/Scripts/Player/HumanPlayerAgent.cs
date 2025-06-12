using UnityEngine;
using KayphoonStudio;

public class HumanPlayerAgent : AgentCharacterBase
{
    public override void InitializeInfo(AgentInfo agentInfo, AgentColor agentColor = AgentColor.Unassigned)
    {
        base.InitializeInfo(agentInfo, agentColor);
        Info.Initialize(agentCharacter: this, agentColor: agentColor);
    }
}

