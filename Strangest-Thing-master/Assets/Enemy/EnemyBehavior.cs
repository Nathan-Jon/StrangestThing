using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		//print (col.gameObject.name);
		if (col.gameObject.name == "CandyCube(Clone)") {
			Grow ();
		}
	}

	void Grow() {
		transform.localScale += new Vector3 (0.2f, 0.2f, 0);
	}
}
