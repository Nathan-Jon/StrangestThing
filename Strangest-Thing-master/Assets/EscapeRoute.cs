using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EscapeRoute : MonoBehaviour 
{

	public GameObject ExitAlert;


	void OnCollisionEnter(Collision col)
	{
		
		if (WinCondition.isFollowing == true && col.gameObject.tag == "Player" )
		{
			SceneManager.LoadScene("WinScreen");
			print ("you win");
		}

		if (WinCondition.isFollowing == false && col.gameObject.tag == "Player")
		{
			ExitAlert.SetActive(true);
		}
	}

	void OnCollisionExit(Collision col)
	{
		ExitAlert.SetActive (false);
	}
}
