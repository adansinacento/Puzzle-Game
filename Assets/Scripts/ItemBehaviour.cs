using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos{
	public class ItemBehaviour : MonoBehaviour {
		
		//el score que ganas es el doble.
		public bool doubleScore = false;
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

	}
}