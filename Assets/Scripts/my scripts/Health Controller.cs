using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public float timer;
    public int health;
    public float originalTimer = 1.5f;
    
    void Death()
    {
        SceneManager.LoadScene("Start");
        health = 10;
    }
    
    int ChangeHealth(int amount, float time)
    {
        if (timer <= 0)
        {
            health += amount;
            timer = time;
        }
        
        return health;
    }
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= 1 * Time.deltaTime;
        }

        if (health < 0)
        {
            Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-1, 1);
        }
    }
}
