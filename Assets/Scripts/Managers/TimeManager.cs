using UnityEngine;
using Obvious.Soap;

public class TimeManager : KS_Singleton<TimeManager>
{
    public FloatVariable RealTimeElapsed => SoapManager.Instance.RealTimeElapsed;
    public FloatVariable GameTimeElapsed => SoapManager.Instance.GameTimeElapsed;

    public bool IsPaused => GameManager.Instance.IsPaused;

    public void Update()
    {
        RealTimeElapsed.Value += Time.deltaTime;

        if (!IsPaused)
        {
            GameTimeElapsed.Value += Time.deltaTime;
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
