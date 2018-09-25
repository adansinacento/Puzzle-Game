﻿    using System.Collections;
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
        public static MapOptions[,] level_1 = new MapOptions[,]
        { 
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Rock, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Rock,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Rock, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice /*Este celda va un item.*/,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.SteppbleFloor,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor}

        };

        /*
        public static MapOptions[,] level_1 = new MapOptions[,] 
        { 
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
        { MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Rock, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Rock,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Rock, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice *Este celda va un item.*,MapOptions.Ice},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
        { MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.SteppbleFloor,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
        { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor}        
        
        };


        
         */



        public static MapOptions[,] level_2 = new MapOptions[,]
        { 
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Rock, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Rock,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.SteppbleFloor, MapOptions.Rock, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice /*Este celda va un item.*/,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
      /**/  { MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
            { MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.SteppbleFloor,MapOptions.Ice,MapOptions.Ice,MapOptions.Ice},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice,MapOptions.Ice,MapOptions.Ice,MapOptions.SteppbleFloor}

        };

        public static MapOptions[,] Level_Tutorial = new MapOptions[,]
        {
            { MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice},
            { MapOptions.Ice,          MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.SteppbleFloor},
            { MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice},
            { MapOptions.Ice,           MapOptions.SteppbleFloor,   MapOptions.Warp, MapOptions.Hole,   MapOptions.Warp,    MapOptions.SteppbleFloor, MapOptions.Ice},
            { MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice},
            { MapOptions.Ice,           MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.Ice,           MapOptions.Ice},
            { MapOptions.SteppbleFloor, MapOptions.Ice,             MapOptions.Ice,  MapOptions.Ice,    MapOptions.Ice,     MapOptions.SteppbleFloor, MapOptions.Ice}
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
            PosicionInicialPersonaje = new Vector2Int(6, 6),
            PosicionRocas = new Vector2Int[] {new Vector2Int(1, 0)},
            PosicionItems = new Vector2Int[] {}
        };

        public static ArmadoNivel CurrentLevel = Tutorial;
    }
}


