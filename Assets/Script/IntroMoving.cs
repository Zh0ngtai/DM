using UnityEngine;

public class IntroMoving : MonoBehaviour
{
    float direction = 0.05f;
    bool isMeeting = false;
    Animator anim;
    Rigidbody rigid;

    private void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isMeeting)
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
    }
}