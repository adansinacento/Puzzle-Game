using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour {
	
	public AudioSource sonido;

	// Use this for initialization
	void Start () 
	{
	//	sonido = gameObject.GetComponent<AudioSource>();
	}
	

	public static void CargarNivel(string pnivel)
	{
		SceneManager.LoadScene (pnivel);
	}
	
	public void Exitgame()
	{
		Application.Quit ();
		print("ME SALI");
	}
}
