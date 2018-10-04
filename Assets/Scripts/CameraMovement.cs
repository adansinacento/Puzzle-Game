using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public class CameraMovement : MonoBehaviour
    {
        Vector3 P1, P2, centro;

        // Use this for initialization
        void Start()
        {
            P1 = GridGenerator.CoordsToWorldPos(0, 0);
            P2 = GridGenerator.CoordsToWorldPos(LevelLayout.CurrentLevel.Nivel.GetLength(0) - 1, LevelLayout.CurrentLevel.Nivel.GetLength(1) - 1);
            P2 = GridGenerator.CoordsToWorldPos(LevelLayout.CurrentLevel.Nivel.GetLength(0) - 1, LevelLayout.CurrentLevel.Nivel.GetLength(1) - 1);
        }

        // Update is called once per frame
        void Update()
        {
            centro = ((P2 - P1) / 2.0f) + P1;
            transform.LookAt(centro);
        }
    }
}


