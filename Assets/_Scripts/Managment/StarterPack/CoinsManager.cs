using UnityEngine;

public class CoinsManager : Singleton<CoinsManager>
{
    public PrefsValue<int> CoinsCount = new PrefsValue<int>("CoinsCount", 0);

    private void Start()
    {
        if (!GameManager.Instance.overridesInstaller.Enable)
            return;
        
        if (GameManager.Instance.overridesInstaller.Coins != -1)
            CoinsCount.Value = GameManager.Instance.overridesInstaller.Coins;
    }
}
