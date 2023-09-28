using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    TopDown_AnimatorController animatorScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorScript = GetComponentInChildren<TopDown_AnimatorController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, 0f);
        }

        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, 0f);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0f, speed);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0f, -speed);
        }

        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false);
        if(other.gameObject.CompareTag("Axe"))
        {
            animatorScript.SwitchToAxe();
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Spikes"))
        {
            gameObject.SetActive(false);
        }
    }
}
