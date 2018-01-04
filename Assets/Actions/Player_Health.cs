using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {

	private bool alive;
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
		}
		if (alive == false) {
			StartCoroutine ("Die");
		}
	}

	// Player has fallen and died
	IEnumerator Die() {
		SceneManager.LoadScene ("Main");
		yield return null;
	}
}
