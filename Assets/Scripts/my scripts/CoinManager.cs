using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinManager : MonoBehaviour
{
    public int gold = 0;
    int CollectCoin (int amount)
    {
        gold += amount;
        return gold;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(("Coin")))
        { 
            CollectCoin(1);
            other.gameObject.SetActive(false);
        }
    }
}
