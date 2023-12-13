using UnityEngine;

public class StatsToggle : MonoBehaviour
{
    public GameObject statsPanel;

    void Start()
    {
    }

    // 스탯 창을 열거나 닫는 메서드
    public void ToggleStatsPanel()
    {
        // 스탯 창 UI를 토글 (보이면 숨기고, 숨겨져 있으면 보이게 함)
        statsPanel.SetActive(!statsPanel.activeSelf);
    }
}
