using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public class CharacterMovement : MonoBehaviour
    {
        public float speed;
        private Vector3 posGO;
        private Transform tr;
        private int posX = 0;
        private int posY = 0;
        public int lives = 1;
        Disparo disparo;

        public ItemBehaviour item_behaviour;
        
        private PossibleDirections DirectionMovement;
        private Quaternion[] rotaciones = new Quaternion[4];
            

        // Use this for initialization
        void Start()
        {
            item_behaviour = Camera.main.GetComponent<ItemBehaviour>();
            speed = 2;
            posGO = transform.position;
            tr = transform;
            DirectionMovement = PossibleDirections.Stopped;
            posX = LevelLayout.CurrentLevel.PosicionInicialPersonaje.x;
            posY = LevelLayout.CurrentLevel.PosicionInicialPersonaje.y;
            disparo = GameObject.FindObjectOfType<Disparo>();

            rotaciones[0] = transform.rotation;
            transform.Rotate(Vector3.up, 90);
            rotaciones[1] = transform.rotation;
            transform.Rotate(Vector3.up, 90);
            rotaciones[2] = transform.rotation;
            transform.Rotate(Vector3.up, 90);
            rotaciones[3] = transform.rotation;
        }

        void Update()
        {
            if (DirectionMovement == PossibleDirections.Stopped)
            {
                PossibleDirections Selected = PossibleDirections.Stopped;
                if (Input.GetKeyDown(KeyCode.D))
                {
                    Selected = PossibleDirections.Right;
                    InicializaDisparo();
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    Selected = PossibleDirections.Left;
                    InicializaDisparo();

                }
                else if (Input.GetKeyDown(KeyCode.W))
                {
                    Selected = PossibleDirections.Forward;
                    InicializaDisparo();

                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    Selected = PossibleDirections.Back;
                    InicializaDisparo();

                }

                if (Selected == PossibleDirections.Stopped) return;

                switch (Selected)
                {
                    case PossibleDirections.Forward:
                        transform.rotation = rotaciones[2];
                        break;
                    case PossibleDirections.Right:
                        transform.rotation = rotaciones[3];
                        break;
                    case PossibleDirections.Back:
                        transform.rotation = rotaciones[0];
                        break;
                    case PossibleDirections.Left:
                        transform.rotation = rotaciones[1];
                        break;
                }

                if (MapOptionsUtils.IsNextSpaceOutOfBouds(Selected, posX, posY))
                    return; //Si la opcion indicada no se puede ahi le cortamos
                
                if (MapOptionsUtils.IsNextSpaceARock(Selected, posX, posY)) //Empuja la roca
                {
                    Vector2Int nextP = MapOptionsUtils.GetNextPointCoordinates(posX, posY, Selected);
                    GridGenerator.MueveRoca(nextP.x, nextP.y, Selected);
                    return;
                }

                DirectionMovement = Selected; //Se asigna la direccion deseada

                //Iteramos hasta que no se pueda mas
                IterateMovement();
            }
            else
            { //Si el estado no es detenido, lo trasladamos
                transform.position = Vector3.MoveTowards(transform.position, posGO, Time.deltaTime * speed);
                if (tr.position == posGO) // Este es el codigo cuando el pinguino llega a un title donde se va a detener
                {
                    switch (LevelLayout.CurrentLevel.Nivel[posX, posY])
                    {
                        case MapOptions.Warp:
                            // TO DO: Implementacion del warp
                            Vector2Int nPoint = MapOptionsUtils.GetOtherWarpCoordinates(posX, posY);
                            posX = nPoint.x;
                            posY = nPoint.y;
                            transform.position = GridGenerator.CoordsToWorldPos(posX, posY, 1);
                            posGO = transform.position;
                            IterateMovement();
                            break;
                        case MapOptions.Hole:
                            RestartCharacter();
	                        break;
                        case MapOptions.Win:
                            Win();
                            break;
                        default:
                            DirectionMovement = PossibleDirections.Stopped; //si no ahi lo paramos
                            break;
                    }
                } 
            }
        }

        void Win()
        {
            Puntuacion puntuacion = GameObject.FindObjectOfType<Puntuacion>(); //Busco al script de puntuacion
            puntuacion.panelWin.SetActive(true);
            puntuacion.enJuego = false;
            LevelLayout.CurrentLevel = LevelLayout.NextLevel;
        }
        void RestartCharacter()
        {
            //Asignamos posiciones en la matriz
            posX = LevelLayout.CurrentLevel.PosicionInicialPersonaje.x;
            posY = LevelLayout.CurrentLevel.PosicionInicialPersonaje.y;
            posGO = GridGenerator.CharacterInitialpos; //Reiniciamos la posicion objetivo
            DirectionMovement = PossibleDirections.Stopped; //Le decimos que se encuentra detenido
            transform.position = GridGenerator.CharacterInitialpos; //Movemos su pos en el mapa
        }

        void InicializaDisparo()
        {
            disparo.StopAllCoroutines();
            disparo.StartCoroutine("Trigger");
        }


        void IterateMovement()
        {
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

                if (MapOptionsUtils.IsThereAnItem(posX, posY))
                {
                    Debug.Log("Entro al item");
                    item_behaviour.StartCoroutine(item_behaviour.ActivatePowerup(item_behaviour.items));
                }

            } while (!MapOptionsUtils.MustStopHere(DirectionMovement, posX, posY) && MapOptionsUtils.IsNextSpaceAvailable(DirectionMovement, posX, posY));
        }
    }
}


