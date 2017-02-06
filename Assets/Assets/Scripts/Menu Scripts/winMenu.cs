using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winMenu : MonoBehaviour {

    public GameObject winUI;

	// Use this for initialization
	void Start () {
        winUI.SetActive(true);
	}

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void highScore()
    {
        SceneManager.LoadScene(0);
    }


}
