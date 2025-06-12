using UnityEngine;
using KayphoonStudio;
using TMPro;
using UnityEngine.UI;

public class AgentStatUI : MonoBehaviour, IAgentColor
{
    public AgentInfoSV agentInfo;

    public TextMeshProUGUI agentNameText;
    public Slider healthSlider;
    public GameObject deadText;

    protected bool isDead = false;

    public void Initialize(AgentInfoSV agentInfo)
    {
        this.agentInfo = agentInfo;
        agentNameText.text = agentInfo.Value.agentName;
        healthSlider.value = agentInfo.Value.agentHP;

        agentInfo.OnValueChanged += OnAgentInfoChanged;
        agentInfo.Value.OnAgentDead += OnAgentDead;
    }

    private void OnAgentInfoChanged(AgentInfo agentInfo)
    {
        healthSlider.value = agentInfo.agentHP;
    }

    private void OnAgentDead(AgentInfo agentInfo)
    {
        // Debug.Log("OnAgentDead");
        CheckAgentDead();
    }

    public AgentColor GetAgentColor()
    {
        return agentInfo.Value.agentColor;
    }

    public void CheckAgentDead()
    {
        if (!isDead)
        {
            if (agentInfo.IsDead())
            {
                isDead = true;
                deadText.SetActive(true);
                healthSlider.gameObject.SetActive(false);
            }
        }
        else
        {
            if (!agentInfo.IsDead())
            {
                isDead = false;
                deadText.SetActive(false);
                healthSlider.gameObject.SetActive(true);
            }
        }
    }
}
