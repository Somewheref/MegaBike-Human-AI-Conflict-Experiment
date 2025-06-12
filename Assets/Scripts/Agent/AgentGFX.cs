using UnityEngine;

public class AgentGFX : MonoBehaviour
{
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer bodyFillRenderer;
    public SpriteRenderer eyeRenderer;
    public SpriteRenderer deadSkeletonRenderer;

    public void Initialize(AgentInfo agentInfo)
    {
        Debug.Log(agentInfo);
        if (agentInfo.bodyCustomization != null)
            bodyRenderer.sprite = agentInfo.bodyCustomization.bodySprite;
        if (agentInfo.eyeSprite != null)
            eyeRenderer.sprite = agentInfo.eyeSprite;
        if (agentInfo.bodyCustomization.bodyFillSprite != null)
            bodyFillRenderer.sprite = agentInfo.bodyCustomization.bodyFillSprite;
    }

    public void ShowDeadSkeleton()
    {
        deadSkeletonRenderer.gameObject.SetActive(true);
        bodyRenderer.gameObject.SetActive(false);
        bodyFillRenderer.gameObject.SetActive(false);
        eyeRenderer.gameObject.SetActive(false);
    }
    
}
