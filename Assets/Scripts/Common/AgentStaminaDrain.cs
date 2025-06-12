using UnityEngine;

public class AgentStaminaDrain : MonoBehaviour
{
    public float drainRate = 0.1f;

    public AgentInfoSV agentInfoSV;

    void Start()
    {
        agentInfoSV = GetComponent<AgentCharacterBase>().Info;
    }

    // Update is called once per frame
    void Update()
    {
        if (agentInfoSV == null)
            return;

        if (agentInfoSV.Value.input == null)
            return;

        Vector3 movement;
        
        agentInfoSV.Value.input.GetDirection(out movement);

        if (movement.magnitude > 0)
        {
            agentInfoSV.ModifyHP(-drainRate * movement.magnitude * Time.deltaTime);
        }

    }
}
