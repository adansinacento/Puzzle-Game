using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interfaz : MonoBehaviour {

	public Text texto_1;
	public Text texto_2;
	public Toggle toggle;
	public InputField input_1;
	public InputField input_2;
	public SaveData datos;

	// Use this for initialization
	void Start () 
	{
		
	}

	public void Cargar()
	{
		// Si no existe regresa un string vacio
		texto_1.text = PlayerPrefs.GetString ("nombre");
		// Si no existe por defecto regresa 0
		texto_2.text = PlayerPrefs.GetInt ("vida").ToString ();

		toggle.isOn = PlayerPrefs.GetInt ("toggle") == 1;

		string ArchivoDatos = PlayerPrefs.GetString ("datos");
		if (ArchivoDatos != "") 
		{
			JsonUtility.FromJson<SaveData> (ArchivoDatos);
		}
	}

	public void Guardar()
	{
		// Guardamos
		PlayerPrefs.SetString ("nombre", input_1.text);

		if (input_2.text != "") 
		{
			PlayerPrefs.SetInt ("vida",int.Parse (input_2.text));
		}
		PlayerPrefs.SetInt("toggle", toggle.isOn ? 1 : 0);
		if (toggle.isOn == true) 
		{
			PlayerPrefs.SetInt ("toggle", 1);
		} 
		else 
		{
			PlayerPrefs.SetInt ("toggle", 0);
		}

		// Limpio
		input_1.text = "";
		input_2.text = "";

		string ArchivoDatos = JsonUtility.ToJson (datos);
		PlayerPrefs.SetString ("datos",ArchivoDatos);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}

[System.Serializable]
public class SaveData
{
	public int Vida;
	public float Fuerza;
	public string Nombre;
	public bool DobleSalto;
	public int Mana;
}