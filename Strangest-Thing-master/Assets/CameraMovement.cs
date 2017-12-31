using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization

	private GameObject player;

	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = new Vector3 (player.transform.position.x, player.transform.position.y, transform.position.z);
		transform.position = (newPos);
	}
}
