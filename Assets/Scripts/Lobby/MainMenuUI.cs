using KayphoonStudio.SimpleHelper;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public Animation exitMainMenuAnim;  // animation component on self
    public Animation toBodyCreationAnim;    // animation on children

    public AnimationClip exitMainMenuAnimClip;

    public PlayerProfileUI mainPlayerProfileUI;

    void Start()
    {
        KS_SimpleSaver.Save("PLAYER_NAME", "Chara");
    }

    public void OnExitMainMenu()
    {
        exitMainMenuAnim.Play();
    }

    public void OnPlayToBodyCreation()
    {
        toBodyCreationAnim.Play();
    }

    public void OnSetupComplete()
    {
        exitMainMenuAnim.clip = exitMainMenuAnimClip;
        exitMainMenuAnim.Play();

        // logic handling
        LobbyScene.Instance.InitLobby(mainPlayerProfileUI);
    }
}
