using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerfireball : MonoBehaviour
{
    private static GameObject player;
    private Rigidbody2D rb;
    private Vector2 startposition;
    private Vector2 targetposition;
    // Start is called before the first frame update
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startposition = (player.transform.position);
        


        if (player.GetComponent<overworldmovement>().direction == "right")
        {
            transform.Translate(startposition + new Vector2(0,0.5f));
            targetposition = startposition + new Vector2(1, 0);
            transform.Translate(startposition);
            transform.position = Vector2.MoveTowards(transform.position, targetposition, 1 * Time.deltaTime);

        }

        if (player.GetComponent<overworldmovement>().direction == "left")
        {

        }

        if (player.GetComponent<overworldmovement>().direction == "up")
        {
            
        }

        if (player.GetComponent<overworldmovement>().direction == "down")
        {
            
        }
    }
}
