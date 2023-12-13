// SelectSceneController.cs

using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneController : MonoBehaviour
{
    // ������ ĳ������ �ʱ� ���Ȱ� ��� ���� ����
    public int selectedCharacterExp = 0;
    public int selectedCharacterGold = 100;
    public int selectedCharacterLevel = 1;
    public int selectedCharacterMaxExp = 100;

    public void StartGame()
    {
        // GameManager�� ã�� �ʱ�ȭ
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            // ������ ĳ������ ������ GameManager�� �����Ͽ� �ʱ�ȭ
            gameManager.InitializePlayerInfo(selectedCharacterExp, selectedCharacterGold, selectedCharacterLevel, selectedCharacterMaxExp);
        }
    }
}
