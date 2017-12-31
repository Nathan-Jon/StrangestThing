using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemogorgonFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject targetToFollow;
	private Rigidbody demoRB;
	private Rigidbody targetRB;
	private Vector2 followVector;
	private Vector3 followDirection;
	private Vector3 newPos;
	public float distance;

	void Start () {
		demoRB = GetComponent<Rigidbody> ();
		targetRB = targetToFollow.GetComponent<Rigidbody> ();
	}




	// Update is called once per frame
	void Update () {

		Vector3 monstPos = GameObject.Find ("Demogorgan").transform.position;
		Vector3 playerPos = GameObject.Find ("Player").transform.position;
		distance = Mathf.Sqrt (((monstPos.x - playerPos.x) * (monstPos.x - playerPos.x)) + ((monstPos.y - playerPos.y) * (monstPos.y - playerPos.y)));

		if (distance < 20) {

			followVector = new Vector2 (targetRB.position.x - demoRB.position.x, targetRB.position.y - demoRB.position.y);
			followVector.Normalize ();

			followDirection = new Vector3 (followVector.x, followVector.y, 0);

			newPos = demoRB.position + 0.2f * followDirection;
			demoRB.MovePosition (newPos);

		}
	}
}
