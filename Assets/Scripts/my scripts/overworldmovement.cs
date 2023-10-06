using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class overworldmovement : MonoBehaviour
{
    public float yspeed;
    public float xDirection;
    public float xVector;
    public float yDirection;
    public float yVector;
    public float xspeed;
    // Start is called before the first frame update
    void Start()
    {
        xspeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            yspeed = 5;
        }
        else
        {
            yspeed = 0;
        }

        yDirection = Input.GetAxis("Vertical");
        yVector = yspeed * yDirection * Time.deltaTime;
        xDirection = Input.GetAxis("Horizontal");
        xVector = xspeed * xDirection * Time.deltaTime;
        
        transform.Translate(xVector,yVector,0);
       
    }
}
