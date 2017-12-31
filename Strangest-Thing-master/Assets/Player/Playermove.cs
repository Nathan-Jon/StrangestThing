using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {

	// Use this for initialization

	Rigidbody rb;
	Vector3 newPos = new Vector3 ();
	KeyCode key;
	Vector3 dir = new Vector3(0,0,0);

	public int faceup = 0;
	public int faceleft = 90;
	public int facedown = 180;
	public int faceright = 270;
	public int rot = 0;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {

		dir.x = 0;
		dir.y = 0;

		if (Input.GetKey(KeyCode.A)) {
			dir.x = -1;
			rot = faceleft;
			this.GetComponent<ThrowCandy> ().direction = Vector3.left;
		}

		if (Input.GetKey (KeyCode.D)) {
			dir.x = 1;
			rot = faceright;
			this.GetComponent<ThrowCandy> ().direction = Vector3.right;
		}


		if (Input.GetKey (KeyCode.W)) {
			dir.y = 1;
			rot = faceup;
			this.GetComponent<ThrowCandy> ().direction = Vector3.up;
		}

		if (Input.GetKey (KeyCode.S)) {
			dir.y = -1;
			rot = facedown;
			this.GetComponent<ThrowCandy> ().direction = Vector3.down;
		}

		rb.MoveRotation (Quaternion.Euler(0,0,rot));


		//newPos = new Vector3(rb.position.x + 0.2f * dir.x, rb.position.y + 0.2f * dir.y, rb.position.z);
		newPos = rb.position + 0.2f * dir;
		rb.MovePosition (newPos);
	}
}
