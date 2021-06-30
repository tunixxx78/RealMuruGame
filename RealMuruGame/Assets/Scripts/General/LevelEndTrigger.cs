using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //SceneManager.LoadScene(4);
            Invoke("loadScene", 1);
            GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger("fade");
        }
    }

    private void loadScene()
    {
        SceneManager.LoadScene(4);
    }
}
