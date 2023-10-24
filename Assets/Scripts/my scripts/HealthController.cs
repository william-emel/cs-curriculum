using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public float timer;
    public float originalTimer = 1.5f;
    public HUD hud;

    
    void Death()
    {
        SceneManager.LoadScene("Start");
        hud.health = 10;
    }
    
    int ChangeHealth(int amount, float time)
    {
        if (timer <= 0)
        {
            hud.health += amount;
            timer = time;
        }
        
        return hud.health;
    }
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= 1 * Time.deltaTime;
        }

        if (hud.health <= 0)
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
        else if (other.gameObject.CompareTag("fireball"))
        {
            Destroy(other.gameObject);
            ChangeHealth(-1, 1);
        }
    }


    
}
