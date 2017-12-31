using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToGame : MonoBehaviour {

	// Use this for initialization



	public void OnMouseClick()
	{
		SceneManager.LoadScene ("Scene1");
	}
	

}
