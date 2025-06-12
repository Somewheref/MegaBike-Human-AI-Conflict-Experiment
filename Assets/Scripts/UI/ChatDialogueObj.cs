using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatDialogueObj : MonoBehaviour
{
    public AgentInfo agentInfo;
    public string headerMsgTemplate = "{0} ({1})  ---VOTED--->  <u>{2}</u> ({3})";

    [Header("UI Reference")]
    public Image eyesImage;
    public Image bodyOutlineImage;
    public Image bodyFillImage;
    public TMP_Text headerText;
    public TMP_Text contentText;

    public void SetInfo(AgentInfo from, AgentInfo to, string reason)
    {
        agentInfo = from;

        eyesImage.sprite = from.eyeSprite;
        bodyOutlineImage.sprite = from.bodyCustomization.bodySprite;
        bodyFillImage.sprite = from.bodyCustomization.bodyFillSprite;
        // TODO set color

        int from_votes = ChattingRoom.Instance.votedAgentsCount[from];
        int to_votes = ChattingRoom.Instance.votedAgentsCount[to];
        headerText.text = string.Format("Voted: {0} ({1})  ---VOTED--->  <u>{2}</u> ({3})", from.agentName, from_votes, to.agentName, to_votes);
        contentText.text = reason;
    }
}
