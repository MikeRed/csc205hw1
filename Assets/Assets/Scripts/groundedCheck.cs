using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundedCheck : MonoBehaviour {

    private playerMovement player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<playerMovement>();
	}

    void OnTriggerEnter2D(Collider2D col) {
        player.grounded = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col) {
        player.grounded = false;
    }
}
