using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    public List<InputBase> inputList = new List<InputBase>();

    public float speed = 10f;
    public Rigidbody rb;
    public ArrowIndicator arrowIndicator;
    public float forceMultiplier = 1000f;

    [Header("Effects")]
    public GameObject forceEffect;

    void Update()
    {
        Vector3 summedDirection = GetBikeDirection();

        rb.linearVelocity = summedDirection * speed;

        arrowIndicator.SetArrow(summedDirection, summedDirection.magnitude);
    }


    public void ApplyForce(Vector3 force, AgentCharacterBase agentCharacter = null)
    {
        rb.AddForce(force * forceMultiplier);

        Vector3 effectPosition = transform.position;
        if (agentCharacter != null)
        {
            effectPosition = agentCharacter.transform.position;
        }

        // instantiate force effect
        GameObject effect = Instantiate(forceEffect, effectPosition, Quaternion.identity);
        effect.transform.forward = -force;
        Destroy(effect, 2f);
    }

    public void AddAgent(AgentInfoSV agentInfo)
    {
        inputList.Add(agentInfo.Value.input);
    }

    public void SetFreezeState(bool freeze)
    {
        if (freeze)
        {
            rb.isKinematic = true;
        }
        else
        {
            rb.isKinematic = false;
        }
    }

    public Vector3 GetBikeDirection()
    {
        Vector3 summedDirection = Vector3.zero;
        Vector3 direction = Vector3.zero;

        foreach (InputBase input in inputList)
        {
            if (input.agentCharacter.isDead) continue;
            input.GetDirection(out direction);  // the get direction here includes the multiplier of strength
            summedDirection += direction;
        }

        return summedDirection;
    }
}
