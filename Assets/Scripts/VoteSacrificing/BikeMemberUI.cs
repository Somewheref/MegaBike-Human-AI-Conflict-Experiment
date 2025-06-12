using KayphoonStudio;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BikeMemberUI : MonoBehaviour
{
    public int memberIndex = -1; // position in the bike
    public bool isPlayer = false;

    [Header("UI References")]
    public Image eyeRenderer;
    public Image bodyOutlineRenderer;
    public Image bodyFillRenderer;
    [Tooltip("Optional")]
    public TMP_Text memberNameText;
    [Tooltip("Optional")]
    public GameObject skullImage;  // optional
    



    public AgentInfo selfInfo;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PlayerDataStorer.Instance)
        {
            KS_Logger.LogError("PlayerDataStorer instance not found!");
            return;
        }

        // check for length of agentInfoList, if it's less than or equal to memberIndex, simply return
        if (PlayerDataStorer.Instance.agentInfoList.Count <= memberIndex - 1)
        {
            gameObject.SetActive(false);
            return;
        }
        selfInfo = PlayerDataStorer.Instance.agentInfoList[memberIndex - 1];

        if (selfInfo == null)
        {
            KS_Logger.LogError("AgentInfo not found for member index: " + (memberIndex - 1));
            return;
        }

        UpdateUI();
    }

    public void UpdateUI()
    {
        if (selfInfo == null) return;

        // Update body and eye renderers
        eyeRenderer.sprite = selfInfo.eyeSprite;
        bodyOutlineRenderer.sprite = selfInfo.bodyCustomization.bodySprite;
        bodyFillRenderer.sprite = selfInfo.bodyCustomization.bodyFillSprite;

        // optional
        if (memberNameText != null)
        {
            memberNameText.text = selfInfo.agentName;
            if (isPlayer)
            {
                memberNameText.text += " (You)";
            }
            if (selfInfo.isDead)
            {
                memberNameText.text += " (Dead)";
            }
        }

        if (skullImage != null)
        {
            skullImage.SetActive(selfInfo.isDead);
            eyeRenderer.gameObject.SetActive(!selfInfo.isDead);
            bodyOutlineRenderer.gameObject.SetActive(!selfInfo.isDead);
            bodyFillRenderer.gameObject.SetActive(!selfInfo.isDead);
        }
    }


    

}
