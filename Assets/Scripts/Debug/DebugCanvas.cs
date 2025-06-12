using UnityEngine;
using TMPro;
using System.Linq;
using KayphoonStudio;
public class DebugCanvas : MonoBehaviour
{
    public CanvasGroup canvas;
    public TextMeshProUGUI realTimeText;
    public TextMeshProUGUI gameTimeText;
    public TextMeshProUGUI inSeasonTimeText;
    public TextMeshProUGUI boxSpawnRateText;
    public TextMeshProUGUI enemySpawnRateText;


    private bool isVisible = false;

    public void Start()
    {
        canvas.KS_Hide();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (!isVisible)
            {
                canvas.KS_Show();
                KS_NotificationCenter.DispatchEvent(NKeys.OnDebugShowAllAgentStats);
            }
            else
            {
                canvas.KS_Hide();
                KS_NotificationCenter.DispatchEvent(NKeys.OnDebugHideAiAgentStats);
            }
            isVisible = !isVisible;

        }

        if (isVisible)
        {
            if (realTimeText) realTimeText.text = TimeManager.Instance.RealTimeElapsed.Value.ToString("F2");
            if (gameTimeText) gameTimeText.text = TimeManager.Instance.GameTimeElapsed.Value.ToString("F2");
            if (inSeasonTimeText) inSeasonTimeText.text = SeasonsManager.Instance.CurrentInSeasonTime.ToString("F2");
            if (boxSpawnRateText) boxSpawnRateText.text = SeasonsManager.Instance.CurrentSeason.GetBoxSpawnRate(SeasonsManager.Instance.CurrentInSeasonTime).ToString("F2");
            if (enemySpawnRateText) enemySpawnRateText.text = SeasonsManager.Instance.CurrentSeason.GetEnemySpawnRate(SeasonsManager.Instance.CurrentInSeasonTime).ToString("F2");
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            // kill a random agent
            AgentManager.Instance.KillRandomAgent();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            // kill a random enemy
            MegaBike megaBike = FindObjectsByType<MegaBike>(FindObjectsSortMode.None).FirstOrDefault();
            if (megaBike != null)
            {
                megaBike.bikeMovement.forceMultiplier = 2000;
            }
        }
        // if (Input.GetKeyDown(KeyCode.F4))
        // {
        //     // kill a random enemy
        //     MegaBike megaBike = FindObjectsByType<MegaBike>(FindObjectsSortMode.None).FirstOrDefault();
        //     if (megaBike != null)
        //     {
        //         megaBike.bikeMovement.forceMultiplier = 500;
        //     }
        // }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            KS_SceneManager.LoadScene("ChatRoom");
        }

    }
}
