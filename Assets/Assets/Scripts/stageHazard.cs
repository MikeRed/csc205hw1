using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stageHazard : MonoBehaviour
{

    public float thrust;
    public Rigidbody2D rb2d;
    public GameObject playerSpawn;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    void FixedUpdate () {
        if (this.transform.position.y > 9.75 || (this.transform.position.y < 4 && this.transform.position.y > -4)) {
            rb2d.AddForce(transform.right * thrust);
        }
        else {
            rb2d.AddForce(transform.right * -thrust);
        }

        if (this.transform.position.x < -25 && this.transform.position.y < -4) {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player") {
            col.gameObject.transform.position = playerSpawn.transform.position;
        }
    }
}
