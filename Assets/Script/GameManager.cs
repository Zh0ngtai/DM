using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글톤 패턴을 사용하여 GameManager에 전역적으로 접근할 수 있도록 합니다.
    public static GameManager instance;

    // 플레이어 정보
    public int Exp;
    public int Gold;
    public int Level;
    public int MaxExp;

    // 이벤트: 정보가 변경될 때 다른 스크립트에서 감지할 수 있도록 합니다.
    public delegate void OnPlayerInfoChanged();
    public event OnPlayerInfoChanged PlayerInfoChanged;

    private void Awake()
    {
        // 싱글톤 패턴 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 플레이어 경험치
    public int experience
    {
        get { return Exp; }
        set
        {
            Exp = Mathf.Clamp(value, 0, MaxExp);
            PlayerInfoChanged?.Invoke();
        }
    }

    // 최대 경험치
    public int maxExperience
    {
        get { return MaxExp; }
        set
        {
            MaxExp = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // 플레이어 골드
    public int gold
    {
        get { return Gold; }
        set
        {
            Gold = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // 플레이어 레벨
    public int level
    {
        get { return Level; }
        set
        {
            Level = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // 플레이어 정보 초기화
    public void InitializePlayerInfo(int initialExperience, int initialGold, int initialLevel, int initialMaxExperience)
    {
        Exp = initialExperience;
        Gold = initialGold;
        Level = initialLevel;
        MaxExp = initialMaxExperience;
        PlayerInfoChanged?.Invoke();
    }
}
