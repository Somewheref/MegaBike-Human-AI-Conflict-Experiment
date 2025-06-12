using UnityEngine;
using Obvious.Soap;
public class SoapManager : KS_Singleton<SoapManager>
{
    public FloatVariable RealTimeElapsed;
    public FloatVariable GameTimeElapsed;

    public void ResetAllData()
    {
        RealTimeElapsed.ResetValue();
        GameTimeElapsed.ResetValue();
    }
}
