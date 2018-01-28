using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {

	public bool alive;
	private int healthPoints;

	// Use this for initialization
	void Start () {
		alive = true;
		healthPoints = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -7) {
			alive = false;
			die ();
		}
	}

	// Player has fallen and died
	void die() {
		SceneManager.LoadScene ("Main");
	}
}
