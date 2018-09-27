using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Pinguinos{
	public class Puntuacion : MonoBehaviour {
		
		
		public int puntuacion;
		public ItemBehaviour ib;
		
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
			if(ib.slowScore == true){
				yield return new WaitForSeconds(2.5f);
			}else if(ib.slowScore == false){
				yield return new WaitForSeconds(1.0f);
			}
			
			if(ib.halfDegen == true){
				puntuacion -= 50;
			}else if(ib.halfDegen == false){
				puntuacion -= 100;
			}
			
			// Actualiza el texto
			texto.text = puntuacion.ToString();
			
			// Se vuelve a ejecutar la corotina
			StartCoroutine("BajarPuntuacion");
		}
		
		void fin() //funcion de GameOver
		{
			if (puntuacion<=0)
			{
				//SceneManager.LoadScene("GameOver");
				
			}
		}
	}
}
