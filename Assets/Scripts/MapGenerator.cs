using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Pinguinos
{
	public class MapGenerator{
		public GameObject ice_block;
		public GameObject rock_block;
		public GameObject snow_block;
		public GameObject hole_block;
		public GameObject item_block;
		public GameObject warp_block;
		public MapOptions opcion;


			// Use this for initialization
			void Start () {
				for(int i = 0;i < (100);i++){
					for(int j = 0;j < (100);j++){

						//opcion = Pinguinos.LevelLayout.CurrentLevel[i,j];

						switch(opcion)
						{
							case MapOptions.Ice:
							//	Instantiate(ice_block,new Vector3())
								break;
						}
					}
				}

			}
	}
}