using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pinguinos
{
    public enum PossibleDirections
    {
        Stopped,
        Left,
        Right,
        Forward,
        Back
    }

    public enum MapOptions {
        Ice,
        Hole,
        Warp,
        SteppbleFloor,
	    Rock,
        Win
    }

    public static class MapOptionsUtils
    {

        public static bool MustStopHere(PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(1)) return true;
                    return TitleStopsYou(LevelLayout.CurrentLevel.Nivel[x, y]);
                case PossibleDirections.Back:
                    if (y == 0) return true;
                    return TitleStopsYou(LevelLayout.CurrentLevel.Nivel[x, y]);
                case PossibleDirections.Left:
                    if (x == 0) return true;
                    return TitleStopsYou(LevelLayout.CurrentLevel.Nivel[x, y]);
                case PossibleDirections.Right:
                    if (x + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(0)) return true;
                    return TitleStopsYou(LevelLayout.CurrentLevel.Nivel[x, y]);
                default:
                    return true; //Default handler
            }
        }

        public static bool IsNextSpaceAvailable(PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case PossibleDirections.Forward:
                    if (y + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(1)) return false;
                    return !IsThereARock(x, y + 1);
                case PossibleDirections.Back:
                    if (y == 0) return false;
                    return !IsThereARock(x, y-1);
                case PossibleDirections.Left:
                    if (x == 0) return false;
                    return !IsThereARock(x-1, y);
                case PossibleDirections.Right:
                    if (x + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(0)) return false;
                    return !IsThereARock(x+1, y);
                default:
                    return false; //Si esta detenido le decimos que no se mueva
            }
        }

        public static bool IsNextSpaceARock(PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case PossibleDirections.Forward:
                    return IsThereARock(x, y + 1);
                case PossibleDirections.Back:
                    return IsThereARock(x, y - 1);
                case PossibleDirections.Left:
                    return IsThereARock(x - 1, y);
                case PossibleDirections.Right:
                    return IsThereARock(x + 1, y);
                default:
                    return false; //Si esta detenido le decimos que no se mueva
            }
        }

        public static bool IsNextSpaceOutOfBouds(PossibleDirections direction, int x, int y)
        {
            switch (direction)
            {
                case PossibleDirections.Forward:
                    return y + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(1);
                case PossibleDirections.Back:
                    return y == 0;
                case PossibleDirections.Left:
                    return x == 0;
                case PossibleDirections.Right:
                    return x + 1 == LevelLayout.CurrentLevel.Nivel.GetLength(0);
                default:
                    return false; // La neta esto no debería llegar
            }
        }

        public static bool IsThereARock(int x, int y)
        {
            for (int i = 0; i < LevelLayout.CurrentLevel.PosicionRocas.Length; i++)
            {
                if (LevelLayout.CurrentLevel.PosicionRocas[i].x == x && LevelLayout.CurrentLevel.PosicionRocas[i].y == y)
                    return true;
            }
            return false;
        }

        private static bool TitleStopsYou(MapOptions title)
        {
            return title == MapOptions.SteppbleFloor || title == MapOptions.Warp || title == MapOptions.Hole || title == MapOptions.Win;
        }

        public static Vector2Int GetOtherWarpCoordinates(int x, int y)
        {
            Vector2Int vInput = new Vector2Int(x, y);
            Vector2Int v1 = new Vector2Int(-1, -1);
            Vector2Int v2 = new Vector2Int(-1, -1);

            for (int i = 0; i < LevelLayout.CurrentLevel.Nivel.GetLength(0); i++)
                for (int j = 0; j < LevelLayout.CurrentLevel.Nivel.GetLength(1); j++)
                    if (LevelLayout.CurrentLevel.Nivel[i, j] == MapOptions.Warp)
                    {
                        if (v1.x == -1)
                            v1.Set(i, j);
                        else
                            v2.Set(i, j);
                    }

            return vInput == v1 ? v2 : v1;
        }

        public static Vector2Int GetNextPointCoordinates(int x, int y, PossibleDirections direction)
        {
            switch (direction)
            {
                case PossibleDirections.Forward:
                    y++;
                    break;
                case PossibleDirections.Back:
                    y--;
                    break;
                case PossibleDirections.Left:
                    x--;
                    break;
                case PossibleDirections.Right:
                    x++;
                    break;
                default:
                    break;
            }
            return new Vector2Int(x, y);
        }
    }
}

