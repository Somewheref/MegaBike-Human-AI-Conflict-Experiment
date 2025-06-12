using UnityEngine;
using KayphoonStudio;

public class InGameSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnSceneToGameOver, OnSceneToGameOver);
    }

    void OnSceneToGameOver(Notification notification)
    {
        // TODO: Implement
        KS_SceneManager.LoadScene("GameOver");
    }

    public void ToVotingScene()
    {
        KS_SceneManager.LoadScene("ChatRoom");
    }
}
