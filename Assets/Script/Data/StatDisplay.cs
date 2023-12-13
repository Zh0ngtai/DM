using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatDisplay : MonoBehaviour
{
    public Text attackText;
    public Text defenseText;
    public Text healthText;

    // ������ �����ϴ� �޼���
    public void SetStats(int attack, int defense, int health)
    {
        // ���ݷ�, ����, ü�� Text ������Ʈ
        attackText.text = "���ݷ�: " + attack.ToString();
        defenseText.text = "����: " + defense.ToString();
        healthText.text = "ü��: " + health.ToString();
    }
}