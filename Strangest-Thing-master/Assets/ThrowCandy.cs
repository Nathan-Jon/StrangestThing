using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCandy : MonoBehaviour {

	public GameObject candyPrefab;

	public Vector3 direction = Vector3.up;

	public int candyNo = 3;

	private float cooldown = 0f;

	public float cooldownBaseTime = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// When space bar is pressed spawn a new candy, provided you own any
		if(Input.GetKeyDown("space") && candyNo > 0 && cooldown <= 0f)
		{
			// Set new rotation
			Quaternion rotation = new Quaternion ();
			// Create the position on the player 
			Vector3 spawnLocation = transform.position + direction;
			// Create the object and pass the direction
			(Object.Instantiate (candyPrefab, spawnLocation, rotation) as GameObject).GetComponent<movement>().direction = direction;
			//Expend 1 candy
			candyNo=candyNo-1;

			cooldown = cooldownBaseTime;

		}	

		if (cooldown > 0f) {
			cooldown -= Time.deltaTime;
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "candyCollect")
		{
			Destroy (col.gameObject);
			candyNo++;

			//when the pickup sweets are added, make sure they're tagged as candyCollect
		}
	}
}
