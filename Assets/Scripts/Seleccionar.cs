using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Seleccionar : MonoBehaviour {
	
	public GameObject[] Personajes;
	
	static int personaje;

	// Use this for initialization
	void Start () 
	{
		if(personaje <= 0 || personaje > 3)
		{
			personaje = 1;
		}
		
		if(SceneManager.GetActiveScene().name == "Level1")
		{
			Instantiate(Personajes[personaje], transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	public void SelectPersonaje(int Personaje)
	{
		personaje = Personaje;
	}
	
	public void CambiarEscena()
	{
		SceneManager.LoadScene ("Level1");
	}
}
