using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlFollow : MonoBehaviour {

	// Use this for initialization

	public GameObject targetToFollow;
	private Rigidbody girlRB;
	private Rigidbody targetRB;
	private Vector2 followVector;
	private Vector3 followDirection;
	private Vector3 newPos;

	void Start () {
		girlRB = GetComponent<Rigidbody> ();
		targetRB = targetToFollow.GetComponent<Rigidbody> ();
	}


	
	// Update is called once per frame
	void Update () {

		if(WinCondition.isFollowing == true){
			print ("HELLO");
			if (Vector3.Distance (girlRB.position, targetRB.position) >= 3f) {

				followVector = new Vector2 (targetRB.position.x - girlRB.position.x, targetRB.position.y - girlRB.position.y);
				followVector.Normalize ();

				followDirection = new Vector3 (followVector.x, followVector.y, 0);

				newPos = girlRB.position + 0.4f * followDirection;
				girlRB.MovePosition (newPos);

			}
		}




	}
}
