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
        private GameObject Item;
        private static List<Rock> Rocks = new List<Rock>();

        Seleccionar Jugador;

        string Player;

        private static float offset = 1;

        public static Vector3 CharacterInitialpos;

        void Start()
        {
            Player = Jugador.ToString();
            // Cargamos Prefabs perrones
            Ice = Resources.Load("Ice") as GameObject;
            SteppableFloor = Resources.Load("SteppableFloor") as GameObject;
            Rock = Resources.Load("Rock") as GameObject;
            Warp = Resources.Load("Warp") as GameObject;
            Hole = Resources.Load("Hole") as GameObject;
            Win = Resources.Load("Win") as GameObject;
            Item = Resources.Load("Item") as GameObject;

            //El prefab del personaje
            Character = Resources.Load(Player) as GameObject;

            //Esta funcion instancia todos los prefabs correspondientes
            CargaNivel();
        }

        public static void MueveRoca(int x, int y, PossibleDirections dir)
        {
            for (int i = 0; i < Rocks.Count; i++)
            {
                if (Rocks[i].posX == x && Rocks[i].posY == y)
                {
                    Debug.Log("Se ha encontrado una roca");
                    LevelLayout.CurrentLevel.PosicionRocas[i] = Rocks[i].Move(dir);
                    return;
                }
            }
        }

        void CargaNivel()
        {
            //Estos for() instancian las cosas necesarias del grid
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

            // Cargamos la pos del personaje y Asignamos el valor al Vector3 (que sirve de referencia para otros scripts)
            Vector2Int CharPos = LevelLayout.CurrentLevel.PosicionInicialPersonaje;
            CharacterInitialpos = new Vector3(CharPos.x * offset, 1, CharPos.y * offset);
            Instantiate(Character, CharacterInitialpos, Quaternion.identity);

            //Instanciamos todas las rocas
            for (int i = 0; i < LevelLayout.CurrentLevel.PosicionRocas.Length; i++)
            {
                Vector3 RockPos = new Vector3(LevelLayout.CurrentLevel.PosicionRocas[i].x, 1, LevelLayout.CurrentLevel.PosicionRocas[i].y);
                GameObject go = Instantiate(Rock, RockPos, Quaternion.identity);
                Rocks.Add(go.GetComponent<Rock>());
                Rocks[i].Init(LevelLayout.CurrentLevel.PosicionRocas[i]);
            }

            for (int i = 0; i < LevelLayout.CurrentLevel.PosicionItems.Length; i++)
            {
                Vector3 RockPos = new Vector3(LevelLayout.CurrentLevel.PosicionItems[i].x, 1, LevelLayout.CurrentLevel.PosicionItems[i].y);
                GameObject go = Instantiate(Item, RockPos, Quaternion.identity);
                //Rocks.Add(go.GetComponent<Rock>());
                //Rocks[i].Init(LevelLayout.CurrentLevel.PosicionRocas[i]);
            }
        }

        public static Vector3 CoordsToWorldPos(int x, int z, int y = 0)
        {
            return new Vector3(x * offset, y, z * offset);
        }
    }
}


