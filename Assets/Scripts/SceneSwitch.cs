using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int scene;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");

        if (collision.gameObject.CompareTag("Player"))
        {
            Scene current = SceneManager.GetActiveScene();

            SceneManager.LoadScene(scene);

            SceneManager.UnloadSceneAsync(current);
        }
    }
}
