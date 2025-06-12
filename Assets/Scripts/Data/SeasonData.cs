using UnityEngine;

[CreateAssetMenu(fileName = "SeasonData", menuName = "ScriptableObjects/SeasonData", order = 1)]
public class SeasonData : ScriptableObject
{
    public float totalDuration;
    public AnimationCurve boxSpawnRateCurve;
    public AnimationCurve enemySpawnRateCurve;
    public float boxSpawnRate;
    public float enemySpawnRate;

    public float nightTimeStart;

    public float GetBoxSpawnRate(float inSeasonTime)
    {
        inSeasonTime = Mathf.Clamp(inSeasonTime, 0, totalDuration);
        return boxSpawnRateCurve.Evaluate(inSeasonTime / totalDuration) * boxSpawnRate;
    }

    public float GetEnemySpawnRate(float inSeasonTime)
    {
        inSeasonTime = Mathf.Clamp(inSeasonTime, 0, totalDuration);
        return enemySpawnRateCurve.Evaluate(inSeasonTime / totalDuration) * enemySpawnRate;
    }
}

