using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class goofyscoring : MonoBehaviour
{
    private float timer;
    private bool iframes;
    private int health;
    private int gold;
    public TextMeshProUGUI goldtext;
    public TextMeshProUGUI healthtext;
    public float originalTimer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        timer = originalTimer;
        void CollectCoin(int amount)
        {
            gold += amount;
            //    .gameObject.SetActive(false);
        }

        void changehealth(int amount)
        {
            health += amount;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = originalTimer;
            //turn off iframes
        }
        void OnTriggerEnter2D(Collider other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
            
            }    
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(("Coin")))
        {
            
        }
    }
}
