using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    private float introDuration = 7f;
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        // 7�ʰ� ���
        if (elapsedTime >= introDuration)
        {
            if (Input.anyKeyDown)
                if (Input.anyKeyDown)
                {
                    SceneManager.LoadScene("MainScene");
                }
        }
    }
}