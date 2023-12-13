// SelectSceneController.cs

using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSceneController : MonoBehaviour
{
    // 선택한 캐릭터의 초기 스탯과 골드 등의 정보
    public int selectedCharacterExp = 0;
    public int selectedCharacterGold = 100;
    public int selectedCharacterLevel = 1;
    public int selectedCharacterMaxExp = 100;

    public void StartGame()
    {
        // GameManager를 찾아 초기화
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            // 선택한 캐릭터의 정보를 GameManager에 전달하여 초기화
            gameManager.InitializePlayerInfo(selectedCharacterExp, selectedCharacterGold, selectedCharacterLevel, selectedCharacterMaxExp);
        }
    }
}
