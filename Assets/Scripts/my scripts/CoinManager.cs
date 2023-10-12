using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.VisualScripting;


public class CoinManager : MonoBehaviour
{
    public HUD hud;
  
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(("Coin")))
        {
            hud.gold += 1;
            other.gameObject.SetActive(false);
        }
    }
}
