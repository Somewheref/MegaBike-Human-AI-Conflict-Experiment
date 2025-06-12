using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Doozy.Runtime.UIManager.Components;
using UnityEngine.EventSystems;

public class OwdiSacrificeItemUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public TMP_Text agentName;
    public Image agentBody;
    public Image agentBodyFill;
    public Image agentEyes;
    public UIButton selectButton;

    private AgentInfo agentInfo;
    private System.Action<OwdiSacrificeItemUI> onItemSelected;
    private System.Action<OwdiSacrificeItemUI> onItemHovered;

    public void SetItem(AgentInfo agentInfo, System.Action<OwdiSacrificeItemUI> onSelected, System.Action<OwdiSacrificeItemUI> onHovered)
    {
        agentName.text = agentInfo.agentName;
        agentBody.sprite = agentInfo.bodyCustomization.bodySprite;
        agentBodyFill.sprite = agentInfo.bodyCustomization.bodyFillSprite;
        agentEyes.sprite = agentInfo.eyeSprite;
        this.agentInfo = agentInfo;
        
        this.onItemSelected = onSelected;
        this.onItemHovered = onHovered;
    }

    public void SelectItem()
    {
        selectButton.OnPointerEnter(new PointerEventData(EventSystem.current));
    }

    public void DeselectItem()
    {
        selectButton.OnPointerExit(new PointerEventData(EventSystem.current));
    }

    public AgentInfo GetAgentInfo()
    {
        return agentInfo;
    }

    // Mouse hover
    public void OnPointerEnter(PointerEventData eventData)
    {
        onItemHovered?.Invoke(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Optional: Add any additional hover exit behavior
    }

    // Mouse click
    public void OnPointerClick(PointerEventData eventData)
    {
        onItemSelected?.Invoke(this);
    }
}
