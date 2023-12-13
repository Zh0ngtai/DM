using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SliderUI : MonoBehaviour
{
    public enum SliderType { Exp }
    public SliderType type;
    public Slider mySlider;

    private void Awake()
    {
        // Slider 컴포넌트를 찾아서 mySlider에 할당
        mySlider = GetComponent<Slider>();
        if (mySlider == null)
        {
            // 예외 처리 또는 경고 메시지 출력
            Debug.LogError("Slider 컴포넌트를 찾을 수 없습니다.");
        }
    }

    private void LateUpdate()
    {
        // mySlider가 null인지 확인
        if (mySlider != null)
        {
            switch (type)
            {
                case SliderType.Exp:
                    mySlider.value = (float)GameManager.instance.Exp / GameManager.instance.MaxExp;
                    break;
            }
        }
        else
        {
            // mySlider가 null인 경우에 대한 예외 처리 또는 경고 메시지 출력
            Debug.LogError("Slider 컴포넌트가 null입니다.");
        }
    }
}
