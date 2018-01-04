using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Garbage_Interactions : MonoBehaviour {

	private Player_Movements player;
	private bool inventoryFull;

	// Use this for initialization
	void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player");
		inventoryFull = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*void OnTriggerEnter2D (BoxCollider2D otherObj) {
		if (otherObj.gameObject.CompareTag("Player")) {
			if (Input.GetButton ("Collect")) {
				Destroy (gameObject);
				bool status;
			}
		}
	}*/
}
