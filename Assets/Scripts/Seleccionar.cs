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
		if(personaje < 0 || personaje > 2)
		{
			personaje = 1;
		}
		
		if(SceneManager.GetActiveScene().name == "Nivel_1")
		{
			Instantiate(Personajes[personaje], new Vector3(0, 0, 0) , Quaternion.identity);
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
		SceneManager.LoadScene ("Menu_Juego");
	}
}
