using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {

    public float forwardMovement;
    public float backwardMovement;
    public float jumpingMovement;

    public bool moving;
    public bool right;
    public bool left;
    public bool grounded;

    public int currentLives = 3;
    public int maxLives = 3;

    private Animator anim;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();

        currentLives = maxLives;
	}

    void Die() {
        SceneManager.LoadScene(1);
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("grounded", grounded);
        anim.SetBool("moving", moving);

        if (currentLives > maxLives) {
            currentLives = maxLives;
        }

        if (currentLives <= 0) {
            Die();
        }
    }

    void FixedUpdate() {

        if (grounded && Input.GetKeyDown(KeyCode.W)) {
            rb2d.AddForce(Vector2.up * jumpingMovement);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moving = true;

            if (left) {
                right = true; left = false;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else {
                right = true; left = false;
            }
            
            gameObject.transform.position += gameObject.transform.right * forwardMovement * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moving = true;

            if (right)
            {
                left = true; right = false;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else {
                left = true; right = false;
            }
            gameObject.transform.position += gameObject.transform.right * backwardMovement * Time.deltaTime;
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            moving = false;
        }
    }
}
