using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Camera_Movement : MonoBehaviour {

	private GameObject player;
	public float xMin, yMin, xMax, yMax;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		xMin = -3;
		xMax = 6;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate () {
		float xValue = Mathf.Clamp (player.transform.position.x, xMin, xMax);
		float yValue = Mathf.Clamp (player.transform.position.y, yMin, yMax);
		gameObject.transform.position = new Vector3 (xValue, yValue, gameObject.transform.position.z);

	}
}
