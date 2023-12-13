using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{
    public static FadeManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static FadeManager instance;

    public Image Panel;
    float time = 0f;
    float F_time = 1f;

    void Start()
    {
        if (instance != null)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void FadeAndLoadScene(string sceneName)
    {
        StartCoroutine(FadeFlow(sceneName));
    }

    IEnumerator FadeFlow(string sceneName)
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;

        // 페이드 아웃
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }

        // 씬 로드하기
        SceneManager.LoadScene(sceneName);

        // 페이드 인
        time = 0f;
        yield return new WaitForSeconds(1f);

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }

        Panel.gameObject.SetActive(false);
        yield return null;
    }
}
