using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {

    public string winScreen = null;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (winScreen != null && winScreen != "")
        {
            SceneManager.LoadScene(winScreen);
        }
    }
}
