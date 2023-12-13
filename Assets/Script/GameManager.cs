using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �̱��� ������ ����Ͽ� GameManager�� ���������� ������ �� �ֵ��� �մϴ�.
    public static GameManager instance;

    // �÷��̾� ����
    public int Exp;
    public int Gold;
    public int Level;
    public int MaxExp;

    // �̺�Ʈ: ������ ����� �� �ٸ� ��ũ��Ʈ���� ������ �� �ֵ��� �մϴ�.
    public delegate void OnPlayerInfoChanged();
    public event OnPlayerInfoChanged PlayerInfoChanged;

    private void Awake()
    {
        // �̱��� ���� ����
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

    // �÷��̾� ����ġ
    public int experience
    {
        get { return Exp; }
        set
        {
            Exp = Mathf.Clamp(value, 0, MaxExp);
            PlayerInfoChanged?.Invoke();
        }
    }

    // �ִ� ����ġ
    public int maxExperience
    {
        get { return MaxExp; }
        set
        {
            MaxExp = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // �÷��̾� ���
    public int gold
    {
        get { return Gold; }
        set
        {
            Gold = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // �÷��̾� ����
    public int level
    {
        get { return Level; }
        set
        {
            Level = value;
            PlayerInfoChanged?.Invoke();
        }
    }

    // �÷��̾� ���� �ʱ�ȭ
    public void InitializePlayerInfo(int initialExperience, int initialGold, int initialLevel, int initialMaxExperience)
    {
        Exp = initialExperience;
        Gold = initialGold;
        Level = initialLevel;
        MaxExp = initialMaxExperience;
        PlayerInfoChanged?.Invoke();
    }
}
