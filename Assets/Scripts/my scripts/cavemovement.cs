using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cavemovement : MonoBehaviour
{
    // Start is called before the first frame update\
    public float walkingspeed;
    public float xDirection;
    public float xVector;
    void Start()
    {
        walkingspeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
