using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public class Rock : MonoBehaviour
    {
        private float speed;
        private Vector3 posGO;
        private Transform tr;
        public int posX = 0;
        public int posY = 0;
        private Vector2 InitialPos;
        private Vector3 WolrdPos;

        private PossibleDirections DirectionMovement;

        // Use this for initialization
        void Start()
        {
            speed = 2;
            posGO = transform.position;
            tr = transform;
            DirectionMovement = PossibleDirections.Stopped;
        }

        public void Init(Vector2Int pos)
        {
            InitialPos = pos;
            posX = pos.x;
            posY = pos.y;
            WolrdPos = new Vector3(pos.x, 1, pos.y);
        }

        public Vector2Int Move(PossibleDirections Selected)
        {
            if (!MapOptionsUtils.IsNextSpaceAvailable(Selected, posX, posY))
                return new Vector2Int(posX, posY); //Si la opcion indicada no se puede ahi le cortamos
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
            return new Vector2Int(posX, posY);
        }

        // Update is called once per frame
        void Update()
        {
            if (DirectionMovement != PossibleDirections.Stopped)
            { //Si el estado no es detenido, lo trasladamos
                transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
                if (tr.position == posGO) // Este es el codigo cuando el pinguino llega a un title donde se va a detener
                {
                    switch (LevelLayout.CurrentLevel.Nivel[posX, posY])
                    {
                        case MapOptions.Warp:
                            // TO DO: Implementacion del warp
                            break;
                        case MapOptions.Hole:
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

