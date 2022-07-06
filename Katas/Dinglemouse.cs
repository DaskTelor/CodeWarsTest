using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{

    internal class Dinglemouse
    {
        public static int[] DryGround(char[][] terrain)
        {
            int[,] terra = new int[terrain.Length, terrain[0].Length];
            int[] result = new int[4];
            for (int i = 0; i < terrain.Length; i++)
                for (int j = 0; j < terrain[0].Length; j++)
                    terra[i, j] = terrain[i][j] == '^' ? 1 : terrain[i][j] == '-' ? -1 : 0;

            for (int i = 0; i < terra.GetLength(0); i++)
                for (int j = 0; j < terra.GetLength(1); j++)
                    return result;
            return result;
        }

    }
}
