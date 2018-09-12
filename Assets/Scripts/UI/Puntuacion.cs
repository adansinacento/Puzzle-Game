using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Puntuacion : MonoBehaviour {
	
	public int puntuacion;
	
	public Text texto;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine("BajarPuntuacion");
		texto.text=puntuacion.ToString();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		fin();
	}
	
	// Baja la puntuacion cada segundo
	IEnumerator BajarPuntuacion()
	{
		// Espera 1 segundo para ejecutarse
		yield return new WaitForSeconds(1f);
		
		// Restamos puntuacion
		puntuacion -= 10;
		
		// Actualiza el texto
		texto.text = puntuacion.ToString();
		
		// Se vuelve a ejecutar la corotina
		StartCoroutine("BajarPuntuacion");
	}
	
	void fin() //funcion de GameOver
	{
		if (puntuacion<=0)
		{
			SceneManager.LoadScene("GameOver");
			
		}
	}
}
