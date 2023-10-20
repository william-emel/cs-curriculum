using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private GameObject player;
    public GameObject fireball;
    private float timer;
    private Vector2 targetPosition;
    private Vector2 startposition;
  
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        startposition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= 1 * Time.deltaTime;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (timer < 0)
            {
                player = other.gameObject;
                targetPosition = player.transform.position;
                targetPosition = player.transform.position;
                Instantiate(fireball);
                fireball.transform.position = startposition;
                transform.position = Vector2.MoveTowards(startposition, targetPosition, 1 * Time.deltaTime);
                timer = 5;
            }
            
            
        

        }
    }
}
