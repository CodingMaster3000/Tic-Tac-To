using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_To
{
    public static class Logic
    {
        public static void CheckGrid(string[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == null)
                    {
                        UIMethods.Write("-");
                    }
                    else
                    {
                        UIMethods.Write($"{grid[i, j]}");
                    }
                }
            }
        }
    }
}
