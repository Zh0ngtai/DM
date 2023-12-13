using UnityEngine;
using UnityEngine.UI;

public class DisplayTextOnCharacter : MonoBehaviour
{
    public string characterName = "Player"; // 캐릭터의 이름
    public Canvas canvas; // 캔버스
    public Text textPrefab; // 텍스트 프리팹

    private Text nameText;

    void Start()
    {
        // 텍스트 생성
        nameText = Instantiate(textPrefab, canvas.transform);
        nameText.text = characterName;
    }

    void Update()
    {
        // 캐릭터의 위치에 맞게 텍스트 위치 조정
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        nameText.transform.position = screenPos;
    }
}