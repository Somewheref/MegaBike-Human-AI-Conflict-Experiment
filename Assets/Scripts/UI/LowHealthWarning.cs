
using UnityEngine;
using UnityEngine.UI;

public class LowHealthWarning : MonoBehaviour
{
    public Image warningOverlay;
    public AnimationCurve fadeInCurve;

    public AgentInfo agentInfo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agentInfo = PlayerDataStorer.Instance.GetPlayerAgentInfo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (agentInfo != null)
        {
            warningOverlay.color = new Color(
                warningOverlay.color.r,
                warningOverlay.color.g,
                warningOverlay.color.b,
                fadeInCurve.Evaluate(agentInfo.agentHP)
            );
        }
    }
}
