using UnityEngine;
using System.Collections.Generic;

public class MegaBike : KS_Singleton<MegaBike>
{
    public BikeMovement bikeMovement;
    public bool hasHumanPlayer;
    public List<Transform> agentParentSeats = new List<Transform>();

    public List<AgentInfoSV> agents = new List<AgentInfoSV>();
    
    public AgentStatUI playerStatUI;

    public Transform playerBikeSeat;

    public void AddAgent(AgentInfoSV agentInfo)
    {
        if (agentInfo.Value.isHumanPlayer)
        {
            hasHumanPlayer = true;
        }

        agents.Add(agentInfo);

        bikeMovement.AddAgent(agentInfo);

        agentInfo.Value.agentCharacter.RegisterMegaBike(this);

        // special case if this bike has human player
        if (agentInfo.Value.isHumanPlayer)
        {
            playerStatUI.Initialize(agentInfo);
        }
        BikeStatsPanelUI.Instance.AddAgentStat(agentInfo);

        AssignAgentToSeat(agentInfo, agentInfo.Value.isHumanPlayer);
    }

    public void AssignAgentToSeat(AgentInfoSV agentInfo, bool isHuman = false)
    {
        // iterate through all seats and find the first empty seat
        foreach (var seat in agentParentSeats)
        {
            if (seat.childCount == 0)
            {
                agentInfo.Value.agentCharacter.transform.SetParent(seat);
                agentInfo.Value.agentCharacter.transform.localPosition = Vector3.zero;
                agentInfo.Value.agentCharacter.transform.localRotation = Quaternion.identity;
                if (isHuman)
                {
                    playerBikeSeat = seat; // set the player bike seat
                }
                break;
            }
        }
    }

    public void OpenedLootbox(Lootbox lootbox)
    {
        lootbox.Open(this, ref agents);
    }

    public List<AgentColor> GetCurrentColorsOnBike()
    {
        List<AgentColor> colors = new List<AgentColor>();
        foreach (var agent in agents)
        {
            colors.Add(agent.Value.agentColor);
        }
        return colors;
    }
}

