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
        public static MapOptions[,] level1 = new MapOptions[,] 
        { 
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice },
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice },
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice },
            { MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice, MapOptions.Ice, MapOptions.Ice, MapOptions.Ice,  MapOptions.Ice }
        };        
    }
}


