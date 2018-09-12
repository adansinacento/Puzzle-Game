using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField]
        private float speed;
        private Vector3 posGO;
        private Transform tr;
        private int posX = 0;
        private int posY = 0;
        private bool FirstCommand = false;

        public enum PossibleDirections
        {
            Stopped,
            Left,
            Right,
            Forward,
            Back
        }
        private PossibleDirections DirectionMovement;
            

        // Use this for initialization
        void Start()
        {
            speed = 2;
            posGO = transform.position;
            tr = transform;
            DirectionMovement = PossibleDirections.Stopped;
        }

        void Update()
        {
            if (DirectionMovement == PossibleDirections.Stopped)
            {
                PossibleDirections Selected = PossibleDirections.Stopped;
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Selected = PossibleDirections.Right;
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    Selected = PossibleDirections.Left;
                }
                else if (Input.GetKeyDown(KeyCode.W))
                {
                    Selected = PossibleDirections.Forward;
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    Selected = PossibleDirections.Back;
                }
                Debug.Log("Se ha seleccionado " + Selected.ToString());
                if (!MapOptionsUtils.IsNextSpaceAvailable(Selected, posX, posY)) return; //Si la opcion indicada no se puede ahi le cortamos
                DirectionMovement = Selected; //Se asigna la direccion deseada

                while  (!MapOptionsUtils.MustStopHere(Selected, posX, posY) && MapOptionsUtils.IsNextSpaceAvailable(Selected, posX, posY))
                {
                    switch (DirectionMovement)
                    {
                        case PossibleDirections.Left:
                            posGO += Vector3.left;
                            posX--;
                            break;
                        case PossibleDirections.Right:
                            posGO += Vector3.right;
                            posX++;
                            break;
                        case PossibleDirections.Forward:
                            posGO += Vector3.forward;
                            posY--;
                            break;
                        case PossibleDirections.Back:
                            posGO += Vector3.back;
                            posY++;
                            break;
                    }
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
                if (tr.position == posGO)
                {
                    DirectionMovement = PossibleDirections.Stopped;
                    Debug.Log("Personaje esta en: " + posX + ", " + posY);
                    Debug.Log("Limites: " + LevelLayout.level1.GetLength(0) + ", " + LevelLayout.level1.GetLength(1));
                }
                    
            }
            
        }

        
        

        // Update is called once per frame
        void FakeUpdate()
        {
            //Aqui toma las decisiones
            if (tr.position == posGO)
            {
                Debug.Log("AHHHH");
                if (true)
                {
                    FirstCommand = true;
                    Debug.Log("Can change direction");
                    DirectionMovement = PossibleDirections.Stopped;
                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        DirectionMovement = PossibleDirections.Right;
                    }
                    else if (Input.GetKeyDown(KeyCode.A))
                    {
                        DirectionMovement = PossibleDirections.Left;
                    }
                    else if (Input.GetKeyDown(KeyCode.W))
                    {
                        DirectionMovement = PossibleDirections.Forward;
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        DirectionMovement = PossibleDirections.Back;
                    }

                }
                else
                {
                    Debug.Log("Cant change direction");
                    Debug.Log(DirectionMovement.ToString());
                }
            }
            if (FirstCommand)
            {
                FirstCommand = false;
                switch (DirectionMovement)
                {
                    case PossibleDirections.Left:
                        posGO += Vector3.left;
                        posX--;
                        break;
                    case PossibleDirections.Right:
                        posGO += Vector3.right;
                        posX++;
                        break;
                    case PossibleDirections.Forward:
                        posGO += Vector3.forward;
                        posY--;
                        break;
                    case PossibleDirections.Back:
                        posGO += Vector3.back;
                        posY++;
                        break;
                }
            }
            

            transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
        }

  
    }
}


