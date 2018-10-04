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
            float y = transform.position.y;
            Vector3 VPP = Camera.main.WorldToViewportPoint(P1);
            Vector3 VPP2 = Camera.main.WorldToViewportPoint(P2);

            while (!isBet0and1(VPP.x) || !isBet0and1(VPP.y) || !isBet0and1(VPP2.x) || !isBet0and1(VPP2.y))
            {
                y += 1;
            }//Ups

            transform.position = new Vector3(centro.x, y, centro.z);
            transform.LookAt(centro);
        }

        bool isBet0and1(float n)
        {
            return n >= 0.0f && n <= 1.0f;
        }
    }
}


