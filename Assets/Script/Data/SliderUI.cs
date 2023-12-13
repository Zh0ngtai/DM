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
        // Slider ������Ʈ�� ã�Ƽ� mySlider�� �Ҵ�
        mySlider = GetComponent<Slider>();
        if (mySlider == null)
        {
            // ���� ó�� �Ǵ� ��� �޽��� ���
            Debug.LogError("Slider ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }

    private void LateUpdate()
    {
        // mySlider�� null���� Ȯ��
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
            // mySlider�� null�� ��쿡 ���� ���� ó�� �Ǵ� ��� �޽��� ���
            Debug.LogError("Slider ������Ʈ�� null�Դϴ�.");
        }
    }
}
