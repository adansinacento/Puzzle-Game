using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Pinguinos{
	public class Puntuacion : MonoBehaviour {
		
		
		public int puntuacion;
		public ItemBehaviour ib;
		public GameObject panelWin;
        public GameObject panelGameover;
		public Text texto;
        public bool enJuego;

        public int scoreMultiplier = 2;
		// Use this for initialization
		void Start () 
		{
			texto.text=puntuacion.ToString();
            enJuego = true; //Inicializa el juego
            InvokeRepeating("ActualizaPuntuacion", 0, 2.5f);
		}
		
		// Update is called once per frame
		void Update ()
        {
                fin(); //Checa si se ha legado el contador a 0 y muestra gameover

            if (enJuego)
                BajarPuntuacion();

            
		}
		
		
		// Baja la puntuacion cada segundo
		void BajarPuntuacion()
		{
                
            puntuacion -= scoreMultiplier;
		
			// Actualiza el texto
			
		}

        public void ReloadScene()
        {
            SceneManager.LoadScene("Level_1");
        }

        void ActualizaPuntuacion()
        {
            texto.text = puntuacion.ToString();

        }

        void fin() //funcion de GameOver
		{
			if (puntuacion<=0)
			{
                panelGameover.SetActive(true);
				
			}
		}
	}
}
