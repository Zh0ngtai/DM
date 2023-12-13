using UnityEngine;
using UnityEngine.UI;

public class DisplayTextOnCharacter : MonoBehaviour
{
    public string characterName = "Player"; // ĳ������ �̸�
    public Canvas canvas; // ĵ����
    public Text textPrefab; // �ؽ�Ʈ ������

    private Text nameText;

    void Start()
    {
        // �ؽ�Ʈ ����
        nameText = Instantiate(textPrefab, canvas.transform);
        nameText.text = characterName;
    }

    void Update()
    {
        // ĳ������ ��ġ�� �°� �ؽ�Ʈ ��ġ ����
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        nameText.transform.position = screenPos;
    }
}