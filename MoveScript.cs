using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour {

	private GameObject player;
	private SpriteRenderer sprite;
	private Rigidbody2D rigidBody;

	public Score playerScore;

	private bool isGrounded;

	private Vector3 playerPosition;
	private Quaternion playerRotation;
	private Vector3 playerJump;

	private float speed = 5f;

	void Start () {
		player = gameObject;
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		sprite = gameObject.GetComponent<SpriteRenderer> ();
	}
	

	void Update () {

		playerPosition = player.transform.position;
		playerRotation = player.transform.rotation;

		//Move left
		if (Input.GetKey ("left") || Input.GetKey (KeyCode.A)) {
			
			playerPosition.x -= 10f * Time.deltaTime;
			sprite.flipX = true;

		}
		if (Input.GetKey ("right") || Input.GetKey (KeyCode.D)) {
			playerPosition.x += 10f * Time.deltaTime;
			sprite.flipX = false;
		}


		player.transform.position = playerPosition;
	

	}
		
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Fire") {
			Destroy (player);
			SceneManager.LoadScene (3);
		}

		if (coll.gameObject.tag == "Map") {

			playerScore.increaseScore ();

		}
	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "Floor")
			isGrounded = false;
	}

}
