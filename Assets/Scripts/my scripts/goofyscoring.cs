using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goofyscoring : MonoBehaviour
{
    public float timer;
    public bool iframes;
    public int health = 100;
    public int gold = 0;
    public TextMeshProUGUI goldtext;
    public TextMeshProUGUI healthtext;
    public float originalTimer = 1.5f;

    //int CollectCoin(int amount)
    //{
       // gold += amount;
        //return gold;
    //}
    //int ChangeHealth(int amount, float time)
    //{
       // if (timer <= 0)
        //{
          //  health += amount;
           // timer = time;
        //}
        
       // return health;
    //}

    //void Death()
    //{
        //health = 100;
        //gold = 0;
        //SceneManager.LoadScene("Start");
   // }
    void Start()
    {
        //timer = originalTimer;
        //health = 100;
        //gold = 0;

    }

    
    
    void Update()
    {
     //   if (timer >= 0)
       // {
         //   timer -= 1 * Time.deltaTime;
       // }

       // if (health < 1)
       // {
          //  Death();
       // }

       // healthtext.text = "Health: " + health;
       // goldtext.text = "Gold: " + gold;







    }
    //void OnTriggerEnter2D(Collider2D other)
  //  {
        //if (other.gameObject.CompareTag(("Coin")))
       // { 
           // CollectCoin(1);
            //other.gameObject.SetActive(false);
       // }
  //  }

   // void OnCollisionEnter2D(Collider2D other)
   // {
      //  if (other.gameObject.CompareTag("Spikes"))
      //  {
      //      ChangeHealth(-10,10);
     //   }
    }

