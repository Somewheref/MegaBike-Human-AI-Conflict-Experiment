using KayphoonStudio;
using UnityEngine;

public class OnOwdiCrashBike : MonoBehaviour
{
    public Animation anim;

    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeStart, OnOwdiCrash);
    }

    void OnOwdiCrash(Notification notification)
    {
        if (anim != null)
        {
            anim.Play();
        }
        else
        {
            Debug.LogWarning("Animation is not assigned.");
        }
    }
}
