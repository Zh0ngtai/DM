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
        // �̵� ���̸鼭 �߰� �ִϸ��̼��� ����� ������ ����
        if (IsMoving())
        {
            // �̵� �߿� �߰� �ִϸ��̼��� ����ϱ� ���� �Ķ���� ���� ����
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // �̵� ���� �ƴϸ� �߰� �ִϸ��̼��� ������� �ʵ��� �Ķ���� ���� ����
            animator.SetBool("IsMoving", false);
        }
    }

    bool IsMoving()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
    }
}