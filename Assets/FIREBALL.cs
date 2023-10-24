using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIREBALL : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 target;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //move towards player's gotten position
        gameObject.transform.position = target * Time.deltaTime;
    }
}
