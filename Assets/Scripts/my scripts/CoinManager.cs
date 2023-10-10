using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class CoinManager : MonoBehaviour
{
    public int gold = 0;
    
    public TextMeshProUGUI CoinText;
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
        CoinText.text = "Gold: " + gold.ToString();
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
