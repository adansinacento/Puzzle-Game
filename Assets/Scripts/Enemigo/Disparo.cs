using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	
	// Pool de la bala
	List<GameObject> Bala = new List<GameObject>();
	
	GameObject Generar_Bala()
	{
		for (int i = 0; i < Bala.Count; i++)
		{
			if(Bala[i].activeSelf == false)
			{
				Bala[i].SetActive(true);
				Bala[i].transform.position = transform.position;
				Bala[i].GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
				return Bala[i];
			}
		}
		
		GameObject Prefab_Bala = Resources.Load<GameObject>("Sphere");
		GameObject go = Instantiate(Prefab_Bala, transform.position, Quaternion.Euler(90, 90, 0));
		Bala.Add(go);
		return go;
	}


	// Use this for initialization
	void Start () 
	{
		StartCoroutine("Trigger");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	IEnumerator Trigger()
	{
		yield return new WaitForSeconds(1f);
		GameObject go = Generar_Bala();
		go.GetComponent<Rigidbody>().AddForce(transform.forward * -800);
		go.GetComponent<Rigidbody>().AddForce(transform.up * 800);
		
		StartCoroutine("Trigger");
	}
}
