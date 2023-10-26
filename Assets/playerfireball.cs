using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfireball : MonoBehaviour
{

    public overworldmovement smth;
    private GameObject player;
    private string direction;
    private Rigidbody2D rb;
    private Vector2 targetposition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = (player.transform.position);
            //  direction = smth.direction;

         if (direction == "right")
         {
             targetposition = new Vector2(5, 0);
             rb.AddForce(targetposition);
         }
        if (direction == "left")
        {
            targetposition = new Vector2(-5, 0);
            rb.AddForce(targetposition);
        }

        if (direction == "up")
        {
            targetposition = new Vector2(0, 5);
            rb.AddForce(targetposition);
        }

        if (direction == "down")
        {
            targetposition = new Vector2(0, -5);
            rb.AddForce(targetposition);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
