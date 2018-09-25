using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {

		
	public string nextScene;

	private void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}

}
