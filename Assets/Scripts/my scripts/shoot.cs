using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private GameObject player;
    public GameObject fireball;
    private float timer;
    private Vector3 startposition;
  
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer < 0)
        {
            if (player != null)
            {
                Instantiate(fireball, transform.position, transform.rotation);
                timer = 2;
                player = null;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer = 2;
            player = other.gameObject;
            
            
        }
    }
}
