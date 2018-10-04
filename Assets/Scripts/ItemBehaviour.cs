using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos{
	public class ItemBehaviour : MonoBehaviour {

		public Coroutine item_coroutine;

		public bool[] items = new bool[] {false, false, false};

		
		//el score que pierdes over time es 2.5 mas lento
		public bool slowScore = false;
		//es el generador del escudo del enemigo
		public bool shieldGeneration = false;
		//checa si el personaje está desbloqueado
		public bool secondCharacterUnlocked = false;
		//este es para que se deslice el doble de rápido
		public bool fastMovement = false;
		//este te quita 75pts en vez de 150pts over time
		public bool halfDegen = false;
		

		WaitForSeconds espera = new WaitForSeconds(5.0f);

		public CharacterMovement jugador;
		public Puntuacion puntos;
		
		public void Start(){
			jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
			puntos = Camera.main.GetComponent<Puntuacion>();
		}
		
		void Update()
		{
			if(items[0] == true) //slowScore
			{
				puntos.scoreMultiplier = 1;
				Debug.Log("SlowScore activated");
			}
			else if(items[1] == true) //shieldGenerator
			{
				jugador.lives = 2;
				Debug.Log("ShiledGenerator activated");
			}
			else if(items[2] == true) //fastMovement
			{
				jugador.speed = 4;
				Debug.Log("fastMovement activated");
			}
			else
			{
				Debug.Log("All items are deactivated");
				jugador.speed = 2;
				puntos.scoreMultiplier = 2;
				jugador.lives = 1;
				items[0] = items[1] = items[2] = false;
			}
		}

		public void Detener(){
			StopCoroutine("ActivatePowerup");
		}

		public IEnumerator ActivatePowerup(bool[] item){
			int random = 0;
			Debug.Log("enumerator");
			item[random] = true;
			yield return espera;
			item[random] = false;
			Detener();
		}

	}

	
}