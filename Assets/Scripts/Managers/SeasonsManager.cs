using KayphoonStudio;
using UnityEngine;
using UnityEngine.Events;

public class SeasonsManager : KS_Singleton<SeasonsManager>
{
    public LootboxManager BoxSpawner;
    public OwdiManager EnemySpawner;

    [Header("Seasons")]
    public SeasonData Summer;
    public SeasonData Winter;

    public SeasonData CurrentSeason => TimeManager.Instance.GameTimeElapsed.Value > Summer.totalDuration ? Winter : Summer;
    public float CurrentInSeasonTime => CurrentSeason == Summer ? TimeManager.Instance.GameTimeElapsed.Value : TimeManager.Instance.GameTimeElapsed.Value - Summer.totalDuration;

    public UnityEvent OnSeasonChange;

    public void Update()
    {
        if (CurrentSeason == Summer && TimeManager.Instance.GameTimeElapsed.Value > CurrentSeason.totalDuration)
        {
            OnSeasonChange?.Invoke();
            KS_NotificationCenter.DispatchEvent(NKeys.OnSeasonChange);
        }

        BoxSpawner.SetMaxLootboxes(CurrentSeason.GetBoxSpawnRate(CurrentInSeasonTime));
        EnemySpawner.SetMaxOwdis(CurrentSeason.GetEnemySpawnRate(CurrentInSeasonTime));
    }
}

