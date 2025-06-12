using UnityEngine;
using Obvious.Soap;
using KayphoonStudio;

using Sirenix.OdinInspector;

public class AgentCharacterBase : MonoBehaviour, IAgentColor
{
    public AgentInfoSV Info;
    public AgentGFX agentGFX;
    public Animation agentJumpAnim;

    [ReadOnly]
    public bool isDead = false;

    [ReadOnly]
    public bool isInitialized = false;

    protected MegaBike megaBike;
    
    protected virtual void Reset()
    {
        agentGFX = GetComponentInChildren<AgentGFX>();
    }

    protected virtual void Awake()

    {

    }


    public virtual void InitializeInfo(AgentInfo agentInfo, AgentColor agentColor = AgentColor.Unassigned)
    {
        if (Info == null)
            Info = SoapUtils.CreateRuntimeInstance<AgentInfoSV>($"{gameObject.name}_AgentInfo");        

        Info.Value = agentInfo;
        isInitialized = true;
        // agentGFX.Initialize(Info.Value);
    }

    public AgentColor GetAgentColor()
    {
        return Info.Value.agentColor;
    }

    public virtual void RegisterMegaBike(MegaBike megaBike)
    {
        this.megaBike = megaBike;
        //agentGFX.Initialize(Info.Value);
    }

    public virtual void PlayApplyForceAnimation(Vector3 direction)
    {
        agentJumpAnim.Play("PlayerJump");
        KS_Timer.DelayedAction(0.56f * 100 / 60, () =>
        {
            ApplyForce(direction);
        });
    }

    public virtual void ApplyForce(Vector3 direction)
    {
        megaBike.bikeMovement.ApplyForce(direction, this);
    }

    [ContextMenu("Kill Agent")]
    public void KillAgent()
    {
        Info.ModifyHP(-999);
    }

    public void AgentDeadEvent()
    {
        if (isDead)
            return;

        isDead = true;
        Info.Value.input.SetImmobile(true);
        KS_NotificationCenter.DispatchEvent(NKeys.OnAgentDead, this);
        // a weird patch fix: game manager somehow is not receiving the notification
        GameManager.Instance.OnAgentDead(null);
        agentGFX.ShowDeadSkeleton();
        KS_Logger.Log($"{gameObject.name} is dead");
    }
}
