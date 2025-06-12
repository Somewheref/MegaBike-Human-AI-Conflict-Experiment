using System.Collections;
using KayphoonStudio;
using UnityEngine;
using Sirenix.OdinInspector;

public class AiInput : InputBase
{
    public AiPersonalitySO aiPersonality;

    public int inputVersion = 1;

    private Lootbox lastTargetLootbox;
    [ReadOnly]
    public BehaviorState behaviorState = BehaviorState.Selfishness;
    [ReadOnly]
    public bool isDetermined = false;

    private Vector3 lastDecidedDirection;
    private float lastDecidedStrength;

    private float stamina => agentCharacter.Info.Value.agentHP;


    public enum BehaviorState
    {
        Selfishness,
        Agreeable,
    }

    void Start()
    {
        StartCoroutine(ApplyForceCoroutine());
        StartCoroutine(NewBehvaiorCoroutine());
        // strength = 0;   // version 2

        KS_Timer.DelayedAction(Random.Range(3, 6), () =>
        {
            GetDirection(out Vector3 direction);
            arrowIndicator.SetArrow(direction, strength);
        });
    }


    override protected void Update()
    {
        base.Update();

        arrowIndicator.SetArrow(direction, strength);

        // special case: if agreeable, the agent will follow the bike direction in update as well
        if (behaviorState == BehaviorState.Agreeable)
        {
            Vector3 tempDirection;
            GetDirection(out tempDirection);
            lastDecidedDirection = (bike.bikeMovement.GetBikeDirection() - tempDirection).normalized;
        }

        // build a per-frame lerp speed with randomness from volatility
        float lerpSpeed = aiPersonality.valueLerpSpeed * getVolatileMultiplier();

        // smoothly approach the decided strength
        strength = Mathf.Lerp(strength, lastDecidedStrength, lerpSpeed * Time.deltaTime);

        // smoothly approach the decided direction, then normalize
        direction = Vector3.Lerp(direction, lastDecidedDirection, lerpSpeed * Time.deltaTime).normalized;

    }

    public override void SetImmobile(bool isImmobile = true)
    {
        base.SetImmobile(isImmobile);
        StopAllCoroutines();
    }


    /// <summary>
    /// Always changing the force, to make it look more dynamic
    /// </summary>
    IEnumerator ApplyForceCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(aiPersonality.decisionUpdateInterval * getVolatileMultiplier());

            //GetDirection(out Vector3 direction);

            // if (inputVersion == 1)
            // {
            //     strength = Mathf.Clamp(Mathf.Max(0, 1 - aiPersonality.lazyness + Random.Range(-0.5f, 0.5f)), 0, 1);
            // }
            // else if (inputVersion == 2)
            // {
            //     arrowIndicator.SetArrow(direction, 1);
            //     base.OnMovementConfirmed();
            //     if (agentCharacter != null)
            //     {
            //         agentCharacter.PlayApplyForceAnimation(direction);
            //     }
            // }

            lastDecidedStrength = Mathf.Max(0, 1 - aiPersonality.lazyness * (1 + (1 - stamina) * aiPersonality.hugerAdditionalSelfishness) * getVolatileMultiplier());

            // alter strength based on the behavior state
            switch (behaviorState)
            {
                case BehaviorState.Selfishness:
                    lastDecidedStrength *= aiPersonality.selfishWorkMultiplier;
                    break;
                case BehaviorState.Agreeable:
                    lastDecidedStrength *= aiPersonality.agreeableMultiplier;
                    break;
            }

            lastDecidedStrength = Mathf.Clamp(lastDecidedStrength, 0, 1);
        }
    }


    /// <summary>
    /// AI will decide what to do
    /// </summary>
    /// <returns></returns>
    IEnumerator NewBehvaiorCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Mathf.Max(0, aiPersonality.decisionUpdateInterval * getVolatileMultiplier()));

            // 1. Determination: if this check is passed, the agent will insist on going for the last target lootbox
            if (lastTargetLootbox != null && lastTargetLootbox.isActiveAndEnabled)
            {
                // check if the last target lootbox is still valid
                if (aiPersonality.determination > Random.Range(0f, 1f))
                {
                    isDetermined = true;
                    Vector3 nearestLootboxPosition = lastTargetLootbox.transform.position;
                    lastDecidedDirection = (nearestLootboxPosition - transform.position).normalized;
                    continue;
                }
            }

            // 2. selfishness: a probability to only go to the nearest lootbox with agent color. If else, go to the nearest lootbox
            if (aiPersonality.selfishness * (1 + (1 - stamina) * aiPersonality.hugerAdditionalSelfishness) > Random.Range(0f, 1f))
            {
                behaviorState = BehaviorState.Selfishness;
                // find nearest lootbox with agent color
                lastTargetLootbox = AiEnvInfoFeed.Instance.getNearestLootBoxPosition(transform, agentCharacter.GetAgentColor());
                Vector3 nearestLootboxPosition = lastTargetLootbox.transform.position;
                lastDecidedDirection = (nearestLootboxPosition - transform.position).normalized;
                continue;
            }

            // 3. agreeable: a probability to go with the crowd
            if (aiPersonality.agreeable > Random.Range(0f, 1f))
            {
                behaviorState = BehaviorState.Agreeable;
                Vector3 tempDirection;
                GetDirection(out tempDirection);
                lastDecidedDirection = (bike.bikeMovement.GetBikeDirection() - tempDirection).normalized;
                continue;
            }

            // default: go to the nearest lootbox
            lastTargetLootbox = AiEnvInfoFeed.Instance.getNearestLootBoxPosition(transform, agentColor: AgentColor.Unassigned);
            Vector3 default_nearestLootboxPosition = lastTargetLootbox.transform.position;
            lastDecidedDirection = (default_nearestLootboxPosition - transform.position).normalized;
        }
    }
    
    float getVolatileMultiplier()
    {
        return Random.Range(1 / (1 + aiPersonality.volatility), 1 + aiPersonality.volatility);
    }
}
