using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PruebaSonido : MonoBehaviour {

	AudioSource audio;
	public Slider Volumen;
	
	// Use this for initialization
	void Start () 
	{
		if(audio == null)
		{
			audio = gameObject.GetComponent<AudioSource>();
		}
		StartCoroutine("CambioSonido");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	IEnumerator CambioSonido()
	{
		yield return new WaitForSeconds(0.05f);
		
		audio.volume = Volumen.value;
		
		StartCoroutine("CambioSonido");
	}
	
}
