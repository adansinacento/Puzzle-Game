using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Vector3 pos;
    private Transform tr;

	// Use this for initialization
	void Start ()
    {
        speed = 2;
        pos = transform.position;
        tr = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D) && tr.position == pos)
        {
            pos += Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.A) && tr.position == pos)
        {
            pos += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.W) && tr.position == pos)
        {
            pos += Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S) && tr.position == pos)
        {
            pos += Vector3.back;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }
}
