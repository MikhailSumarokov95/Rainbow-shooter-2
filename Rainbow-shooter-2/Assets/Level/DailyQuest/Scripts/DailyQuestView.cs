using TMPro;
using UnityEngine;
using static DailyQuest;

public class DailyQuestView : MonoBehaviour
{
    [SerializeField] private Name nameQuest; 
    [SerializeField] private TMP_Text text;

    private void OnEnable()
    {
        text.text = DailyProgress[nameQuest].ToString();
    }
}
