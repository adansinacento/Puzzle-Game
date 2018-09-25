using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour 
{

	NextScene nextScene;



	// Use this for initialization
	void Start () 
	{
		nextScene = GameObject.FindObjectOfType<NextScene> ();
	}


	public void GoTo(string _escena)
	{
		nextScene.nextScene = _escena;
		SceneManager.LoadScene("SceneLoader", LoadSceneMode.Additive);
	}

}
