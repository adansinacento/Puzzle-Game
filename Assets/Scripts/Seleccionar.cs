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
		if(SceneManager.GetActiveScene().name == "Prueba_Personajes")
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
		SceneManager.LoadScene ("Prueba_Personajes");
	}
}
