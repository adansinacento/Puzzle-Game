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
	    Rock,
	    Item
    }

    public static class MapOptionsUtils
    {

        public static bool MustStopHere(CharacterMovement.PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case CharacterMovement.PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.ActualLevel.GetLength(1)) return true;
                    return TitleStopsYou(LevelLayout.ActualLevel[x, y]);
                case CharacterMovement.PossibleDirections.Back:
                    if (y == 0) return true;
                    return TitleStopsYou(LevelLayout.ActualLevel[x, y]);
                case CharacterMovement.PossibleDirections.Left:
                    if (x == 0) return true;
                    return TitleStopsYou(LevelLayout.ActualLevel[x, y]);
                case CharacterMovement.PossibleDirections.Right:
                    if (x + 1 == LevelLayout.ActualLevel.GetLength(0)) return true;
                    return TitleStopsYou(LevelLayout.ActualLevel[x, y]);
                default:
                    return true; //Default handler
            }
        }

        public static bool IsNextSpaceAvailable(CharacterMovement.PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case CharacterMovement.PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.ActualLevel.GetLength(1)) return false;
                    return !TitleStopsYouNext(LevelLayout.ActualLevel[x, y+1]);
                case CharacterMovement.PossibleDirections.Back:
                    if (y == 0) return false;
                    return !TitleStopsYouNext(LevelLayout.ActualLevel[x, y-1]);
                case CharacterMovement.PossibleDirections.Left:
                    if (x == 0) return false;
                    return !TitleStopsYouNext(LevelLayout.ActualLevel[x-1, y]);
                case CharacterMovement.PossibleDirections.Right:
                    if (x + 1 == LevelLayout.ActualLevel.GetLength(0)) return false;
                    return !TitleStopsYouNext(LevelLayout.ActualLevel[x+1, y]);
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
            return title == MapOptions.SteppbleFloor || title == MapOptions.Warp;
        }

        public static Vector2Int GetOtherWarpCoordinates(int x, int y)
        {
            Vector2Int vInput = new Vector2Int(x, y);
            Vector2Int v1 = new Vector2Int(-1, -1);
            Vector2Int v2 = new Vector2Int(-1, -1);

            for (int i = 0; i < LevelLayout.ActualLevel.GetLength(0); i++)
                for (int j = 0; j < LevelLayout.ActualLevel.GetLength(1); j++)
                    if (LevelLayout.ActualLevel[i, j] == MapOptions.Warp)
                    {
                        if (v1.x == -1)
                            v1.Set(i, j);
                        else
                            v2.Set(i, j);
                    }

            return vInput == v1 ? v2 : v1;
        }
    }
}

