using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerfireball : MonoBehaviour
{
    private static GameObject player;
    private Rigidbody2D rb;
    public Vector2 startposition;
    public Vector2 targetposition;

    private Vector2 position;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startposition = player.transform.position;
        if (player.GetComponent<overworldmovement>().direction == "right")
        {
            targetposition = startposition + new Vector2(5, 0);
        } else if (player.GetComponent<overworldmovement>().direction == "left") {
            targetposition = startposition + new Vector2(-5, 0);
        } else if (player.GetComponent<overworldmovement>().direction == "up") {
            targetposition = startposition + new Vector2(0, 5);
        } else if (player.GetComponent<overworldmovement>().direction == "down") {
            targetposition = startposition + new Vector2(0, -5);
        }
    }

    void Update()
    {
        position = transform.position;
        transform.position = Vector2.MoveTowards(transform.position, targetposition, 1 * Time.deltaTime);
        if (position == targetposition)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
