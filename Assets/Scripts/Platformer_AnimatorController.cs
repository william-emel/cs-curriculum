using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer_Animator : MonoBehaviour
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
        if (Input.GetAxis("Horizontal") != 0)
        {
            anim.enabled = true;
            anim.SetBool("isWalking", true);

            if (Input.GetAxis("Horizontal") > 0)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetMouseButton(0))
        {
            anim.SetTrigger("Attack");
        }
    }
}
