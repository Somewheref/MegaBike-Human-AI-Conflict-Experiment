using UnityEngine;
using KayphoonStudio;
public class OnOwdiHit : MonoBehaviour
{
    public void OnHit()
    {
        KS_Logger.Log("Owdi hit");
        KS_NotificationCenter.DispatchEvent(NKeys.OnOwdiSacrificeStart);
        Destroy(gameObject);
    }
}
