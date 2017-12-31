using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roaming : MonoBehaviour {

	public float distance;
	public float cooldown = 0f;
	public float[] destinx;
	public float[] destiny;
	private int rando;
	private Vector3 newPos;
	private Rigidbody demoRB;

	// Use this for initialization
	void Start () {
		demoRB = GetComponent<Rigidbody> ();

		destinx = new float[13];
		destiny = new float[13];

		destinx [0] = -38f;
		destinx [1] = -75f;
		destinx [2] = -85f;
		destinx [3] = -95f;
		destinx [4] = -105f;
		destinx [5] = -90f;
		destinx [6] = -63f;
		destinx [7] = -35f;
		destinx [8] = -63f;
		destinx [9] = -10f;
		destinx [10] = -17f;
		destinx [11] = -20f;
		destinx [12] = -8f;

		destiny [0] = -50f;
		destiny [1] = -65f;
		destiny [2] = -83f;
		destiny [3] = -70f;
		destiny [4] = -50f;
		destiny [5] = -45f;
		destiny [6] = -60f;
		destiny [7] = -49f;
		destiny [8] = -20f;
		destiny [9] = -10f;
		destiny [10] = -28f;
		destiny [11] = -42.5f;
		destiny [12] = -55f;

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 monstPos = GameObject.Find ("Demogorgan").transform.position;
		Vector3 playerPos = GameObject.Find ("Player").transform.position;
		distance = Mathf.Sqrt (((monstPos.x - playerPos.x) * (monstPos.x - playerPos.x)) + ((monstPos.y - playerPos.y) * (monstPos.y - playerPos.y)));

		print ("help");

		if ((distance > 20)&&cooldown <= 0f) {
			rando = Random.Range (0, 12);

			print ("help");

			newPos = new Vector3(destinx[rando],destiny[rando],demoRB.position.z);
			demoRB.MovePosition (newPos);
		}

		if (cooldown > 0f) {
			cooldown -= Time.deltaTime;
		} else {
			cooldown = 5f;
		}
	}
}
