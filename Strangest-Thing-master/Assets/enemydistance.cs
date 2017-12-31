using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydistance : MonoBehaviour {

	public float distance;
	public float xdistance, ydistance;

	// Use this for initialization
	void Start () {
		
	}
		
	public float getDistance(){
		return distance;
	}

	// Update is called once per frame
	void Update () {

		Vector3 monstPos = GameObject.Find ("Demogorgan").transform.position;
		Vector3 playerPos = GameObject.Find ("Player").transform.position;

		distance = Mathf.Sqrt (((monstPos.x - playerPos.x) * (monstPos.x - playerPos.x)) + ((monstPos.y - playerPos.y) * (monstPos.y - playerPos.y)));
		xdistance = Mathf.Sqrt ((monstPos.x - playerPos.x) * (monstPos.x - playerPos.x));
		ydistance = Mathf.Sqrt ((monstPos.y - playerPos.y) * (monstPos.y - playerPos.y));

		if (distance > 15) {
			monstPos.z = 10;	
		}else if((distance>5)&&(distance<15)){
			if (Input.GetKey(KeyCode.A)) {
				if (playerPos.x < monstPos.x) {
					monstPos.z = 10;
				} else {
					monstPos.z = 0;
				}
				if (ydistance > 6) {
					monstPos.z = 10;
				}
			}
			if (Input.GetKey (KeyCode.D)) {
				if (playerPos.x < monstPos.x) {
					monstPos.z = 0;
				}else {
					monstPos.z = 10;
				}
				if (ydistance > 6) {
					monstPos.z = 10;
				}
			}


			if (Input.GetKey (KeyCode.W)) {
				if (playerPos.y > monstPos.y) {
					monstPos.z = 10;
				}else {
					monstPos.z = 0;
				}
				if (xdistance > 6) {
					monstPos.z = 10;
				}
			}

			if (Input.GetKey (KeyCode.S)) {
				if (playerPos.y < monstPos.y) {
					monstPos.z = 10;
				}else {
					monstPos.z = 0;
				}
				if (xdistance > 6) {
					monstPos.z = 10;
				}
			}
		}else
		{
			monstPos.z=0;
		}
		transform.position = new Vector3 (monstPos.x, monstPos.y, monstPos.z);
	}
}
