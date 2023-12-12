using UnityEngine;

public class IntroRtanMoving : MonoBehaviour
{
    bool isMeeting = false;
    Animator anim;
    Rigidbody2D rigid;
    public int nextmove;


    void Awake()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>(); // Animator를 초기화
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2 (nextmove, rigid.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.gameObject.tag == "Player")
        {
            isMeeting = true;
            anim.SetBool("IsMeeting", true);
        }
    }

    private void Think() 
    {
        nextmove = Random.Range(-1, 2);
    }
}