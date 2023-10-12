using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public CoinManager coinmanager;
    public HealthController healthcontroller;
    public TextMeshProUGUI Cointext;
    public TextMeshProUGUI Healthtext;
    public int health;
    public int gold;

    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Cointext.text = "Gold: " + gold.ToString();
        Healthtext.text = "Health: " + health.ToString();
    }
}
