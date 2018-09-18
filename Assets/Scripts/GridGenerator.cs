using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

	public GameObject black_block;
	public GameObject white_block;
	public Vector3 startingPosition = new Vector3Int(-355,277,0);
	public int xpos,ypos;
	public bool grid = false;
	
	
	void Start(){

		for(int i = 0;i < 100;i++){

			//if(xpos == )

			if(grid == false){
				Instantiate(white_block,new Vector3Int(xpos,ypos,0),Quaternion.identity);

				grid = true;
			} else if(grid == true){
				Instantiate(black_block,startingPosition,Quaternion.identity);

				grid = false;
			}
		}
	}
}
