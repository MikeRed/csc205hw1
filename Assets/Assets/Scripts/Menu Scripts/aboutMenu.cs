using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aboutMenu : MonoBehaviour {

    public GameObject aboutUI;

    // Use this for initialization
    void Start()
    {
        aboutUI.SetActive(true);
    }

    public void mainMenu() {
        SceneManager.LoadScene(0);
    }
}
