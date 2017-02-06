using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour {

    public float spawnTime = 10f;
    public GameObject Barrel;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn() {
        Instantiate(Barrel, this.transform.position, this.transform.rotation );
	}
}
