using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Awake()
    {
        if (!Progress.IsSetDefaultWeapons())
        {
            FindObjectOfType<ShopAttachment>(true).SetDefaultSetting();
            FindObjectOfType<AmmunitionShop>(true).ReplenishAmmunition();
        }
        //if (!Progress.IsGuideCompleted()) StartGame();
    }

    public void StartSurvivalGame() => SceneManager.LoadScene(3);

    public void StartWaveGame() => SceneManager.LoadScene(2);
}
