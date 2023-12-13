using UnityEngine;
using UnityEngine.UI;
public class TextUI : MonoBehaviour
{
    public enum TextType { Level, Gold}
    public TextType type;
    public Text myText;

    private void Awake()
    {
        // Text 컴포넌트를 찾아서 myText에 할당
        myText = GetComponent<Text>();
        if (myText == null)
        {
            // 예외 처리 또는 경고 메시지 출력
            Debug.LogError("Text 컴포넌트를 찾을 수 없습니다.");
        }
    }

    private void LateUpdate()
    {
        // myText가 null인지 확인
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
            // myText가 null인 경우에 대한 예외 처리 또는 경고 메시지 출력
            Debug.LogError("Text 컴포넌트가 null입니다.");
        }
    }
}
