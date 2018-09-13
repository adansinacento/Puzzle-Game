using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public enum MapOptions {
        Ice,
        Wall,
        Hole,
        Warp,
        SteppbleFloor,
        Rock
    }

    public static class MapOptionsUtils
    {

        public static bool MustStopHere(CharacterMovement.PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case CharacterMovement.PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.level1.GetLength(1)) return true;
                    return TitleStopsYou(LevelLayout.level1[x, y]);
                case CharacterMovement.PossibleDirections.Back:
                    if (y == 0) return true;
                    return TitleStopsYou(LevelLayout.level1[x, y]);
                case CharacterMovement.PossibleDirections.Left:
                    if (x == 0) return true;
                    return TitleStopsYou(LevelLayout.level1[x, y]);
                case CharacterMovement.PossibleDirections.Right:
                    if (x + 1 == LevelLayout.level1.GetLength(0)) return true;
                    return TitleStopsYou(LevelLayout.level1[x, y]);
                default:
                    return true; //Default handler
            }
        }

        public static bool IsNextSpaceAvailable(CharacterMovement.PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case CharacterMovement.PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.level1.GetLength(1)) return true;
                    return !TitleStopsYouNext(LevelLayout.level1[x, y+1]);
                case CharacterMovement.PossibleDirections.Back:
                    if (y == 0) return true;
                    return !TitleStopsYouNext(LevelLayout.level1[x, y-1]);
                case CharacterMovement.PossibleDirections.Left:
                    if (x == 0) return true;
                    return !TitleStopsYouNext(LevelLayout.level1[x-1, y]);
                case CharacterMovement.PossibleDirections.Right:
                    if (x + 1 == LevelLayout.level1.GetLength(0)) return true;
                    return !TitleStopsYouNext(LevelLayout.level1[x+1, y]);
                default:
                    return false; //Si esta detenido le decimos que no se mueva
            }
        }

        private static bool TitleStopsYouNext(MapOptions title)
        {
            return title == MapOptions.Wall || title == MapOptions.Rock;
        }

        private static bool TitleStopsYou(MapOptions title)
        {
            return title == MapOptions.SteppbleFloor;
        }
    }
}

