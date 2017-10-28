using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Move : MonoBehaviour {

	private int playerSpeed = 10;
	private bool facingRight;
	private int jumpPower = 1250;
	private float xDirection;

	// Use this for initialization
	void Start () {
	
	}
	 
	// Move player's sprite based on button pressed
	void movePlayer() {
		// Left and right movements
		xDirection = Input.GetAxis ("Horizontal");
		if (xDirection < 0.0f && !facingRight) {
			turnPlayer ();
		}
		else if (xDirection > 0.0f && facingRight) {
			turnPlayer ();
		}

		if(Input.GetButtonDown("Jump")) {
			jumpPlayer();
		}

		//PHYSICS
		gameObject.GetComponent<Rigidbody2D> ().velocity =
			new Vector2 (xDirection * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	// Controls player's jump movement
	void jumpPlayer() {
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpPower);
	}

	// Changes which direction player is facing
	void turnPlayer() {
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}

	// Update is called once per frame
	void Update () {
		movePlayer ();
	}
}
