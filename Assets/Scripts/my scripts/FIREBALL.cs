using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIREBALL : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 target;
    private GameObject player;
    private Vector2 position;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        target = player.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target, 5 * Time.deltaTime);
        if (position == target)
        {
            Destroy(gameObject);
        }
    }
}
