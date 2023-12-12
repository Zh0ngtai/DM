using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    private float introDuration = 7f;
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        // 7초 동안 대기
        if (elapsedTime >= introDuration)
        {
            // 아무 키나 입력을 받으면 GameScene 씬으로 전환
            if (Input.anyKeyDown)
                if (Input.anyKeyDown)
                {
                    SceneManager.LoadScene("MainScene");
                }
        }
    }
}