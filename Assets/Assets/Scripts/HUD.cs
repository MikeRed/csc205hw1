using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public int numLives;
    public Text LivesUI;

	// Use this for initialization
	void Start () {
        LivesUI = GetComponent<Text>();
        numLives = 3;
	}
	
	// Update is called once per frame
	void Update () {
        LivesUI.text = "Lives: " + numLives;
	}
}
