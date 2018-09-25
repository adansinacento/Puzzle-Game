using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public class GridGenerator : MonoBehaviour
    {
        private GameObject Ice;
        private GameObject SteppableFloor;
        private GameObject Rock;
        private GameObject Warp;
        private GameObject Hole;
        private GameObject Win;
        private GameObject Character;

        private float offset = 1;

        void Start()
        {
            Ice = Resources.Load("Ice") as GameObject;
            SteppableFloor = Resources.Load("SteppableFloor") as GameObject;
            Rock = Resources.Load("Rock") as GameObject;
            Warp = Resources.Load("Warp") as GameObject;
            Hole = Resources.Load("Hole") as GameObject;
            Win = Resources.Load("Win") as GameObject;

            Character = Resources.Load("Character") as GameObject;

            CargaNivel();
        }
        

        void CargaNivel()
        {
            for (int i = 0; i < LevelLayout.CurrentLevel.Nivel.GetLength(0); i++)
                for (int j = 0; j < LevelLayout.CurrentLevel.Nivel.GetLength(1); j++)
                {
                    switch (LevelLayout.CurrentLevel.Nivel[i, j])
                    {
                        case MapOptions.Ice:
                            Instantiate(Ice, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                        case MapOptions.SteppbleFloor:
                            Instantiate(SteppableFloor, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                        case MapOptions.Rock:
                            Instantiate(Rock, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                        case MapOptions.Warp:
                            Instantiate(Warp, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                        case MapOptions.Hole:
                            Instantiate(Hole, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                        case MapOptions.Win:
                            Instantiate(Win, new Vector3(i * offset, 0, j * offset), Quaternion.identity, transform);
                            break;
                    }
                }
            Vector2Int CharPos = LevelLayout.CurrentLevel.PosicionInicialPersonaje;
            Instantiate(Character, new Vector3(CharPos.x * offset, 0, CharPos.y * offset), Quaternion.identity);
        }
    }
}


