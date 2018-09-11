using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {
	
	public int puntuacion;
	
	public Text texto;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine("BajarPuntuacion");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
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
}
