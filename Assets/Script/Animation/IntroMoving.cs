using UnityEngine;

public class IntroMoving : MonoBehaviour
{
    float direction = 0.05f;
    Animator anim;

    private void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position.y < -10 || transform.position.x > 12)
        {
            direction = 0;
        }

        transform.position += new Vector3(direction, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rtan")
        {
            StopMoving();
            // 애니메이션 재생
            anim.SetBool("ismeeting", true);

        }
    }

    // 이동을 멈추는 함수
    private void StopMoving()
    {
        // 이동을 멈추는 코드
        direction = 0;
    }
}
