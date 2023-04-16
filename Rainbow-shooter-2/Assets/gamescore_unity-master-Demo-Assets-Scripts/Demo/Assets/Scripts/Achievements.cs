using UnityEngine;
using GameScore;
public class Achievements : MonoBehaviour
{
    // Все эти методы вызываются через UI - Achievements
    // All this methods are called via UI - Achievements
    public void AchievementsOpen()
    {
        print("AchievementsOpen");
        GS_Achievements.Open();
    }

    public void AchievementsFetch()
    {
        GS_Achievements.Fetch();
    }

    public void AchievementsUnlock(string idOrTag)
    {
        // Tag - COINS
        GS_Achievements.Unlock(idOrTag);
    }

    //public void AchievementSetProgress()
    //{
    //    print("AchievementSetProgress");
    //    GS_Achievements.SetProgress("kill10", 11);
    //}
}
