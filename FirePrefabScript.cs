using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePrefabScript : MonoBehaviour {

	private GameObject currentFire;

	private float speed = 10f;

	void Start () {
		currentFire = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		currentFire.transform.Translate (Vector3.down * Time.deltaTime * speed);
	}

	void OnCollisionEnter2D(Collision2D coll) {

		Destroy (currentFire);

	}
}
