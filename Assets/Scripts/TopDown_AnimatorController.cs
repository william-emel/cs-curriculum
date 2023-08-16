using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_AnimatorController : MonoBehaviour
{
    Animator anim;
    SpriteRenderer sprite;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
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
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 && !(Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 1))
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
            anim.enabled = false;
        }

        if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Attack");
        }
    }




}