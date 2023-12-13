using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public Character character;
    Animator anim;
    SpriteRenderer Spr;
    public SelectChar[] chars;


    void Start()
    {
        anim = GetComponent<Animator>();
        Spr = GetComponent<SpriteRenderer>();
        if (DataMgr.instance.currentCharacter == character) Onselct();
        else OnDeselct();
    }

    private void OnMouseUpAsButton()
    {
        DataMgr.instance.currentCharacter = character;
        Onselct();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i]!=this) chars[i].OnDeselct();
        }
    }
    private void OnDeselct()
    {
        anim.SetBool("IsMoving", false);
        Spr.color = new Color(0.6f, 0.6f, 0.6f);
        Debug.Log("선택해제");
    }    
    private void Onselct()
    {
        anim.SetBool("IsMoving", true);
        Spr.color = new Color(1f, 1f, 1f);
    }    
}
