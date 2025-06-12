using UnityEngine;
using UnityEngine.InputSystem;

public class InputBase : MonoBehaviour
{
    public MegaBike bike;
    public AgentCharacterBase agentCharacter;

    protected Vector3 direction;
    protected float strength;

    protected Vector3 lastForceDirection;

    private ArrowIndicator _arrowIndicator;
    public ArrowIndicator arrowIndicator
    {
        get
        {
            if (_arrowIndicator == null) _arrowIndicator = transform.parent.GetComponentInChildren<ArrowIndicator>();
            return _arrowIndicator;
        }
    }

    public virtual void GetDirection(out Vector3 direction)
    {
        direction = this.direction * strength;
    }

    public virtual void SetImmobile(bool isImmobile = true)
    {
        this.enabled = !isImmobile;
        StopAllCoroutines();

        if (isImmobile)
        {
            direction = Vector3.zero;
            strength = 0;
            arrowIndicator.HideArrow();
        }
    }

    protected virtual void Update()
    {
        // find the bike as target if target is null
        if (bike == null)
        {
            bike = GetComponentInParent<MegaBike>();
            if (bike == null)
            {
                bike = FindObjectsByType<MegaBike>(FindObjectsSortMode.None)[0];
            }
            if (bike == null)
            {
                return;
            }
        }
        if (agentCharacter == null)
        {
            agentCharacter = GetComponentInParent<AgentCharacterBase>();
        }
    }


    public virtual void OnMovementConfirmed(InputAction.CallbackContext context)
    {
        OnMovementConfirmed();
    }

    public virtual void OnMovementConfirmed()
    {
        lastForceDirection = direction;
    }

    public virtual Vector3 GetLastForceDirection()
    {
        return lastForceDirection;
    }
}
