using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveExit : MonoBehaviour
{
    bool unload = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");

        if (collision.gameObject.CompareTag("Player"))
        {
            Scene current = SceneManager.GetActiveScene();

            SceneManager.LoadScene(1);

            Scene newScene = SceneManager.GetActiveScene();
            

            SceneManager.UnloadSceneAsync(current);
        }
    }
}
