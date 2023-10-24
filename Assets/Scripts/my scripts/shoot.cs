using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private GameObject player;
    public GameObject fireball;
    private float timer;
    private Vector3 startposition;
  
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            if (player != null)
            {
                timer -= 1 * Time.deltaTime;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (timer < 0)
            {
                player = other.gameObject;
                Instantiate(fireball);
                fireball.SetActive(true);
                timer = 5;
            }
            
            
        

        }
    }
}
