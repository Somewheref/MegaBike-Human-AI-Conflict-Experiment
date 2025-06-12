using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class VoteSelectButton : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [Header("UI References")]
    public Button button;             // assign in Inspector (or will grab same GameObject)
    public TMP_Text labelText;        // the TextMeshPro label to recolor
    public BikeMemberUI bikeMemberUI; // the UI element to highlight

    [Header("Hover Settings")]
    public Color hoverColor = Color.red;
    public Texture2D hoverCursor;     // assign your cursor image here
    public Vector2 cursorHotspot = Vector2.zero;

    // private state
    private Color originalButtonColor;
    private Color originalTextColor;
    private bool isSelected = false;
    private bool isActive = true;

    void Awake()
    {
        if (button == null) button = GetComponent<Button>();
        if (labelText == null)
            Debug.LogWarning("No TMP_Text assigned to HoverSelectableButton on " + gameObject.name);

        // cache original colors
        originalButtonColor = button.image.color;
        if (labelText != null)
            originalTextColor = labelText.color;
    }

    void Start()
    {
        if (bikeMemberUI.selfInfo.isDead || bikeMemberUI.selfInfo.isHumanPlayer)
        {
            // if the agent is dead or is a human player, disable the button
            isActive = false;
            button.interactable = false;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isSelected || !isActive) return;
        button.image.color = hoverColor;
        if (labelText != null)
            labelText.color = hoverColor;
        Cursor.SetCursor(hoverCursor, cursorHotspot, CursorMode.ForceSoftware);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (isSelected || !isActive) return;
        button.image.color = originalButtonColor;
        if (labelText != null)
            labelText.color = originalTextColor;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isActive) return;
        isSelected = true;
        button.Select();           // make this button the selected UI element
        OnButtonClicked();         // your custom click logic
    }

    /// <summary>
    /// Override or fill in this method to handle the click.
    /// </summary>
    protected virtual void OnButtonClicked()
    {
        PlayerVotingPage.Instance.PlayerSelectVote(bikeMemberUI.selfInfo);
    }

    /// <summary>
    /// Call this to clear the clicked/selected state and restore visuals.
    /// </summary>
    public void ResetSelection()
    {
        isSelected = false;
        button.image.color = originalButtonColor;
        if (labelText != null)
            labelText.color = originalTextColor;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void OnDisable()
    {
        ResetSelection();
    }
}
