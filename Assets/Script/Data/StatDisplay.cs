using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatDisplay : MonoBehaviour
{
    public Text attackText;
    public Text defenseText;
    public Text healthText;

    // 스탯을 설정하는 메서드
    public void SetStats(int attack, int defense, int health)
    {
        // 공격력, 방어력, 체력 Text 업데이트
        attackText.text = "공격력: " + attack.ToString();
        defenseText.text = "방어력: " + defense.ToString();
        healthText.text = "체력: " + health.ToString();
    }
}