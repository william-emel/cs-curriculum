using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class bridgemove : MonoBehaviour
{
    // Start is called before the first frame update
    public bool start;
    public Vector3 torment;
    

    void Start()
    {
        start = false;
        transform.position = new Vector2(20.68f, -59.68f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (start)
        {
            if (transform.position == torment)
            {
                torment = new Vector3(Random.Range(-34, 10), Random.Range(-115, -57), 0);
            }

            transform.position = Vector3.MoveTowards(transform.position, torment, 15f * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            start = true;
        }
    }
}
