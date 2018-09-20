using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour {
	
	public AudioSource click;

	// Use this for initialization
	void Start () 
	{
		click = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Sonido()
	{
		click.Play();
	}
	
	public void cargarnivel(string pnivel)
	{
		SceneManager.LoadScene (pnivel);
	}
	
	public void Exitgame()
	{
		Application.Quit ();
		print("ME SALI");
	}
}
