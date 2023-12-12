using UnityEngine;

public class IntroRtanMoving : MonoBehaviour
{
    float direction = 0.005f;
    bool IsMeeting = false;
    Animator anim;

    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>(); // Animator�� �ʱ�ȭ
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            direction = 0;
        }

        if (transform.position.x > 12)
        {
            direction = 0;
        }
        transform.position += new Vector3(direction, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // �ִϸ��̼� ���
            anim.SetBool("Ismeeting", true);
        }
    }
}