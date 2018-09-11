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

        private enum PossibleDirections
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

        // Update is called once per frame
        void Update()
        {
            //Aqui toma las decisiones
            if (tr.position == posGO)
            {
                Debug.Log("AHHHH");
                if (CanChangeDirection())
                {
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
                }
            }
            
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
                    posGO += Vector3.back;
                    posY--;
                    break;
                case PossibleDirections.Back:
                    posGO += Vector3.forward;
                    posY++;
                    break;
            }

            transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
        }

        private bool CanChangeDirection()
        {
            bool IsPossible = false;
            switch (DirectionMovement)
            {
                case PossibleDirections.Stopped:
                    IsPossible = true;
                    break;
                case PossibleDirections.Left:
                    IsPossible = (posX < LevelLayout.level1.GetLength(0) && TitleCausesStop(LevelLayout.level1[posX+1, posY]));
                    break;
                case PossibleDirections.Right:
                    IsPossible = (posX > 0 && TitleCausesStop(LevelLayout.level1[posX - 1, posY]));
                    break;
                case PossibleDirections.Forward:
                    IsPossible = (posY < LevelLayout.level1.GetLength(0) && TitleCausesStop(LevelLayout.level1[posX, posY + 1]));
                    break;
                case PossibleDirections.Back:
                    IsPossible = (posY > 0 && TitleCausesStop(LevelLayout.level1[posX, posY - 1]));
                    break;
            }
            return IsPossible;
        }

        private bool TitleCausesStop(MapOptions title)
        {
            return title == MapOptions.Wall || title == MapOptions.Rock || title == MapOptions.SteppbleFloor;
        }
    }
}


