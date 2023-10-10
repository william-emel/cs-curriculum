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
    private new Vector2 targetPosition;
    
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
            timer -= 1 * Time.deltaTime;
        } 
        if (timer < 0)
        {
           targetPosition = player.transform.position;
           Instantiate(fireball);
           fireball.transform.Translate(9.324f,11.979f,0);
           fireball.GetComponent<Rigidbody>().AddForce(0,0,0);
           timer = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            
        }
    }
}
