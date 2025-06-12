using KayphoonStudio;
using UnityEngine;

public class OnVotingFinished : MonoBehaviour
{
    public GameObject[] enableObjectsImmediately;

    public float disableDelay = 0.5f;
    public GameObject[] objectsToDisable;

    public float enabledDelay = 2f;
    public GameObject[] objectsToEnable;


    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnAgentVoteSequenceFinished, OnVotingFinishedHandler);
    }

    void OnVotingFinishedHandler(object votedAgent)
    {
        KS_Timer.DelayedEndOfFrameAction(() =>
        {
            foreach (var obj in enableObjectsImmediately)
            {
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }

            KS_Timer.DelayedAction(disableDelay, () =>
            {
                // disable the specified GameObjects
                foreach (var obj in objectsToDisable)
                {
                    if (obj != null)
                    {
                        obj.SetActive(false);
                    }
                }
            });

            KS_Timer.DelayedAction(enabledDelay, () =>
            {
                foreach (var obj in objectsToEnable)
                {
                    if (obj != null)
                    {
                        obj.SetActive(true);
                    }
                }
            });
            
        });
    }
}
