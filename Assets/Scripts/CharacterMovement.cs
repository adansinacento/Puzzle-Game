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

                if (Selected == PossibleDirections.Stopped) return;

                if (!MapOptionsUtils.IsNextSpaceAvailable(Selected, posX, posY))
                    return; //Si la opcion indicada no se puede ahi le cortamos

                DirectionMovement = Selected; //Se asigna la direccion deseada

                do
                { //Lo movemos en esa direccion hasta que no se pueda mas
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
                            posY++;
                            break;
                        case PossibleDirections.Back:
                            posGO += Vector3.back;
                            posY--;
                            break;
                    }
                } while (!MapOptionsUtils.MustStopHere(Selected, posX, posY) && MapOptionsUtils.IsNextSpaceAvailable(Selected, posX, posY));
            }
            else
            { //Si el estado no es detenido, lo trasladamos
                transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
                if (tr.position == posGO) // Este es el codigo cuando el pinguino llega a un title donde se va a detener
                {

                    switch (LevelLayout.ActualLevel[posX, posY])
                    {
                        case MapOptions.Warp:
                            // TO DO: Implementacion del warp
                            break;
                        case MapOptions.Hole:
                            // TO DO: Implementacion del hoyo
                            break;
                        default:
                            DirectionMovement = PossibleDirections.Stopped; //si no ahi lo paramos
                            break;
                    }
                } 
            }
        }
    }
}


