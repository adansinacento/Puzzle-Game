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

        public static MapOptions[,] level_Tutorial = new MapOptions[,] 
        { 
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice},
            { MapOptions.Rock, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice},
            { MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Warp,  MapOptions.Hole, MapOptions.Warp, MapOptions.SteppbleFloor, MapOptions.Ice},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice},
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice},
            { MapOptions.SteppbleFloor, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.SteppbleFloor, MapOptions.Ice}
        };


        public static MapOptions[,] ActualLevel = level_1; 
    }
}


