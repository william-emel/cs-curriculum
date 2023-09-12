using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_AnimatorController : MonoBehaviour
{
    Animator anim;
    SpriteRenderer sprite;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        //start off facing to the right.
        anim.SetBool("isWalking", false);
        anim.SetInteger("walkDir", 1);
        sprite.flipX = true;

    }

    private void Update()
    {
        PlayAnimations();

    }

    void PlayAnimations()
    {
        //if either horizontal or vertical is not equal to zero but not both
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 && !(Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0))
        {
            anim.enabled = true;
            anim.SetBool("isWalking", true);
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.SetInteger("walkDir", 1);
                sprite.flipX = true;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                anim.SetInteger("walkDir", 1);
                sprite.flipX = false;
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                anim.SetInteger("walkDir", 0);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                anim.SetInteger("walkDir", 2);
            }
        }
        else
        {
            anim.SetBool("isWalking", false);
            if (!anim.GetBool("Attack"))
            {
                anim.enabled = false;
            }
        }

        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);
        if (!info.IsName("Shovel_Swing_Horizontal") && !info.IsName("Shovel_Swing_Up") && !info.IsName("Shovel_Swing_Down"))
        {
            anim.SetBool("Attack", false);
            if (Input.GetMouseButton(0))
            {
                anim.enabled = true;
                anim.SetBool("Attack", true);
                anim.SetBool("isWalking", false);
            }
        }
            
    }

}