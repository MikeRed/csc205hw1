using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuMenu : MonoBehaviour {

    public GameObject mainMenuUI;

    // Use this for initialization
    void Start()
    {
        mainMenuUI.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void about() {
        SceneManager.LoadScene(2);
    }

    public void highScore()
    {
        SceneManager.LoadScene(0);
    }

}
