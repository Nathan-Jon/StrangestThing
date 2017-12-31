using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private float movementSpeed = 20f;

	public Vector3 direction = Vector3.left;

	private float lifeTime = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (direction * movementSpeed * Time.deltaTime);
		lifeTime -= Time.deltaTime;
		if (lifeTime < 0f) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Environment" || col.gameObject.name == "Demogorgan") {
			Destroy (this.gameObject);
		}
	}
}
