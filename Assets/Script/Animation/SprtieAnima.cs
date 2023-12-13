using UnityEngine;

public class SpriteAnima : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 이동 중이면서 추가 애니메이션을 재생할 조건을 설정
        if (IsMoving())
        {
            // 이동 중에 추가 애니메이션을 재생하기 위해 파라미터 값을 설정
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // 이동 중이 아니면 추가 애니메이션을 재생하지 않도록 파라미터 값을 설정
            animator.SetBool("IsMoving", false);
        }
    }

    bool IsMoving()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
    }
}