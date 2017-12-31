using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	void OnCollisionEnter(Collision Col)
	{
		if(Col.gameObject.tag =="Player")
		{
			Debug.Log ("Dead");
			SceneManager.LoadScene("GameOverScreen");
		}
	}
}
