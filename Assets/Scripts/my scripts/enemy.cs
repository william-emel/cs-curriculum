using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private bool inRange;
    private GameObject player;
    private float delay;
    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
        delay = 5;
        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        position = player.transform.position;
        if (inRange == true )
        {
            Vector2.MoveTowards(transform.position, position, 1 * Time.deltaTime);
        }

        if (inRange == false && delay > 0)
        {
            delay -= 1 * Time.deltaTime;
            Vector2.MoveTowards(transform.position, position, 1 * Time.deltaTime);
        } else if (inRange == false && delay <= 0)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }
}
