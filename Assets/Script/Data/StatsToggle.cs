using UnityEngine;

public class StatsToggle : MonoBehaviour
{
    public GameObject statsPanel;

    void Start()
    {
    }

    // ���� â�� ���ų� �ݴ� �޼���
    public void ToggleStatsPanel()
    {
        // ���� â UI�� ��� (���̸� �����, ������ ������ ���̰� ��)
        statsPanel.SetActive(!statsPanel.activeSelf);
    }
}
