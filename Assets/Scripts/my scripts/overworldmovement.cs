using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Timeline;

public class overworldmovement : MonoBehaviour
{
    public float yspeed;
    public float xDirection;
    public float xVector;
    public float yDirection;
    public float yVector;
    public float xspeed;
    public string direction = "up";
    public float timer;
    private bool platform;
    private bool inAir;
    public GameObject projectile;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        xspeed = 5;
        timer = 1;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && platform && !inAir  )
        {
            rb.AddForce(transform.up * 7,ForceMode2D.Impulse);
        }
        if (timer > 0)
        {
            timer -= 1 * Time.deltaTime;
        }
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            yspeed = 5;
        }
        else if (scene.name == "Platformer")
        {
            platform = true;
            yspeed = 0;
        }
        else
        {
            yspeed = 0;
        }

        yDirection = Input.GetAxis("Vertical");
        yVector = yspeed * yDirection * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        xVector = xspeed * xDirection * Time.deltaTime;
        
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction = "right";
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            direction = "left";
        } 
        if (Input.GetAxis("Vertical") > 0)
        {
            direction = "up";
        } 
        if (Input.GetAxis("Vertical") < 0)
        {
            direction = "down";
        }

        transform.Translate(xVector,yVector,0);

        if (Input.GetMouseButtonDown(0))
        {
            if (timer < 0)
            {
                Instantiate(projectile,transform.position,transform.rotation);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (platform == true)
        {
            transform.SetParent(null);
            inAir = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (platform == true)
        {
            transform.parent = other.transform;
            inAir = true;
        }
    }
}
