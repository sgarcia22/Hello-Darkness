using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawn : MonoBehaviour {

	public GameObject[] fires;
	public GameObject[] maps;

	private GameObject currentFire;
	private GameObject currentMap;

	private float timeToSpawnOne = .2f;
	private float timeToSpawnTwo = .4f;
	private float timeToSpawnThree = .6f;
	private float timeToSpawnFour = 7f;


	void Start () {
		InvokeRepeating ("spawnFireTime", 1.0f,timeToSpawnOne);
		InvokeRepeating ("spawnFireTime", 2.0f,timeToSpawnTwo);
		InvokeRepeating ("spawnFireTime", 3.0f,timeToSpawnThree);
		InvokeRepeating ("spawnMap", 1.0f,timeToSpawnFour);

	}
	

	void spawnFireTime() {
		currentFire = fires [Random.Range (0, fires.Length)];
		GameObject newFire = Instantiate (currentFire);
		newFire.transform.parent = gameObject.transform;

	}

	void spawnMap() {
		currentMap = maps [Random.Range (0, maps.Length)];
		GameObject newMap = Instantiate (currentMap);
		newMap.transform.parent = gameObject.transform;

	}
		

}
