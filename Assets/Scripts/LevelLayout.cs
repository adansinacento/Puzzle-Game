    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    /// <summary>
    /// Esta clase asigna los layouts
    /// </summary>
    public class LevelLayout
    {
        // En teoría cargariamos esto de un .json si tuvieramos el level creator

        public static MapOptions[,] Level_Tutorial = new MapOptions[,]
        {
            { MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole, MapOptions.Hole,   MapOptions.Hole,    MapOptions.Hole,          MapOptions.Hole,          MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Win,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.Ice,  MapOptions.Warp, MapOptions.Hole,   MapOptions.Warp,    MapOptions.SteppbleFloor, MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.SteppbleFloor,  MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.SteppbleFloor, MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole, MapOptions.Hole,   MapOptions.Hole,    MapOptions.Hole,          MapOptions.Hole,          MapOptions.Hole}
        };

        public static MapOptions[,] Level_Nivel_1 = new MapOptions[,]
        {
            { MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole, MapOptions.Hole,   MapOptions.Hole,    MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Win,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Warp,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Ice, MapOptions.Ice,            MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.SteppbleFloor,  MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,           MapOptions.Ice, MapOptions.Ice,            MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Ice,     MapOptions.Ice,    MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,  MapOptions.SteppbleFloor,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice, MapOptions.Ice,            MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice, MapOptions.Ice,            MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,            MapOptions.Warp,  MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice, MapOptions.Ice,            MapOptions.Hole},
            { MapOptions.Hole, MapOptions.SteppbleFloor, MapOptions.Ice,             MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,      MapOptions.Ice,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,          MapOptions.Ice,             MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,      MapOptions.SteppbleFloor, MapOptions.Ice,     MapOptions.Ice,            MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,          MapOptions.Ice,             MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,      MapOptions.SteppbleFloor, MapOptions.Ice,     MapOptions.Ice,            MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole, MapOptions.Hole,   MapOptions.Hole,    MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole}
        };

        public static MapOptions[,] Level_Nivel_2 = new MapOptions[,]
        {
            { MapOptions.Hole, MapOptions.Hole,           MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,            MapOptions.Hole,     MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole,           MapOptions.Hole,          MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Win,            MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.Warp,            MapOptions.Hole,     MapOptions.Ice,           MapOptions.SteppbleFloor,  MapOptions.SteppbleFloor,  MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.SteppbleFloor,   MapOptions.Hole,     MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,           MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.Ice,             MapOptions.Hole,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.SteppbleFloor,  MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.Ice,             MapOptions.Hole,     MapOptions.Ice,           MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.SteppbleFloor,  MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Ice,             MapOptions.Hole,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.Ice,           MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.SteppbleFloor,  MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,             MapOptions.Hole,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.Ice,            MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,             MapOptions.Hole,     MapOptions.Hole,          MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.SteppbleFloor,  MapOptions.Ice,            MapOptions.Hole, MapOptions.Ice,           MapOptions.Ice,             MapOptions.Hole,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.SteppbleFloor,  MapOptions.Ice,            MapOptions.Ice,  MapOptions.Ice,           MapOptions.SteppbleFloor,   MapOptions.Hole,     MapOptions.SteppbleFloor, MapOptions.Ice,            MapOptions.SteppbleFloor,  MapOptions.Ice,           MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Ice,            MapOptions.Ice,            MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.SteppbleFloor,   MapOptions.Warp,     MapOptions.SteppbleFloor, MapOptions.Hole,           MapOptions.Ice,            MapOptions.SteppbleFloor, MapOptions.Hole},
            { MapOptions.Hole, MapOptions.Hole,           MapOptions.Hole,           MapOptions.Hole, MapOptions.Hole,          MapOptions.Hole,            MapOptions.Hole,     MapOptions.Hole,          MapOptions.Hole,           MapOptions.Hole,           MapOptions.Hole,          MapOptions.Hole}
        };

        public class ArmadoNivel
        {
            public MapOptions[,] Nivel;
            public Vector2Int PosicionInicialPersonaje;
            public Vector2Int[] PosicionRocas;
            public Vector2Int[] PosicionItems;
        }

        public static ArmadoNivel Tutorial = new ArmadoNivel() {
            Nivel = Level_Tutorial,
            PosicionInicialPersonaje = new Vector2Int(7, 8),
            PosicionRocas = new Vector2Int[] {new Vector2Int(2, 3)},
            PosicionItems = new Vector2Int[] {}
        };

        public static ArmadoNivel Nivel_1 = new ArmadoNivel()
        {
            Nivel = Level_Nivel_1,
            PosicionInicialPersonaje = new Vector2Int(10, 10),
            PosicionRocas = new Vector2Int[] { new Vector2Int(5, 5), new Vector2Int(3, 7), new Vector2Int(2, 6) },
            PosicionItems = new Vector2Int[] {}

        };

        public static ArmadoNivel Nivel_2 = new ArmadoNivel() {

            Nivel = Level_Nivel_2,
            PosicionInicialPersonaje = new Vector2Int(10,10),
            PosicionRocas = new Vector2Int[] {new Vector2Int(2,9),new Vector2Int(5,9),new Vector2Int(6,3)},
            PosicionItems=new Vector2Int[] {}
        };

        public static ArmadoNivel CurrentLevel = Tutorial;

        public static ArmadoNivel NextLevel = Nivel_1;
}
}


