using UnityEngine;
using UnityEngine.UI;
public class TextUI : MonoBehaviour
{
    public enum TextType { Level, Gold}
    public TextType type;
    public Text myText;

    private void Awake()
    {
        // Text ������Ʈ�� ã�Ƽ� myText�� �Ҵ�
        myText = GetComponent<Text>();
        if (myText == null)
        {
            // ���� ó�� �Ǵ� ��� �޽��� ���
            Debug.LogError("Text ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }

    private void LateUpdate()
    {
        // myText�� null���� Ȯ��
        if (myText != null)
        {
            switch (type)
            {
                case TextType.Level:
                    myText.text = "Level: " + GameManager.instance.Level.ToString();
                    break;

                case TextType.Gold:
                    myText.text = "Gold: " + GameManager.instance.Gold.ToString();
                    break;
            }
        }
        else
        {
            // myText�� null�� ��쿡 ���� ���� ó�� �Ǵ� ��� �޽��� ���
            Debug.LogError("Text ������Ʈ�� null�Դϴ�.");
        }
    }
}
