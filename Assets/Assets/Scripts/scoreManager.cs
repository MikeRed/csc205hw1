using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour {

    public int score;
    public GUIText scoreText;

	// Use this for initialization
	void Start () {
        score = 10;
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateScore() {
        scoreText.text = "Score: " + score;
    }

    public void reduceScore() {
        score -= 1;
        UpdateScore();
    }
}
