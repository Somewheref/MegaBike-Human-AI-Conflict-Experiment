using KayphoonStudio.SimpleHelper;
using Sirenix.OdinInspector;
using UnityEngine;

public class DebugChatRoom : MonoBehaviour
{
    public GameObject dataStorerPrefab;

    public GameObject VotingPageParent;
    public GameObject ChattingPage;
    public GameObject VotePersonPage;
    public GameObject VoteReasonPage;
    public GameObject PreVotingPage;

    [Button("Reset to default")]
    public void ResetToDefault()
    {
        VotingPageParent.SetActive(false);
        ChattingPage.SetActive(false);
        VotePersonPage.SetActive(true);
        VoteReasonPage.SetActive(false);
        PreVotingPage.SetActive(true);
    }

    private void Awake()
    {
        if (PlayerDataStorer.Instance == null)
        {
            Instantiate(dataStorerPrefab);
            KS_SimpleSaver.Save("PLAYER_NAME", "[Debug Name]");
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F4))
        {
            Time.timeScale = 20f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
