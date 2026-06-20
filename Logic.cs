using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_To
{
    public static class Logic
    {
        public static void CheckGrid(string[,] grid, int gridSize)
        {
            for (int j = 0; j < gridSize; j++)
            {
                UIMethods.Write("+");
                for (int k = 0; k < 3; k++)
                {
                    UIMethods.Write("-");

                }
            }
            UIMethods.Write("+");
            UIMethods.Write("\n");
            for (int i = 0; i < gridSize; i++)
            {
                UIMethods.Write("|");

                for (int j = 0; j < gridSize; j++)
                {
                    if (grid[i, j] == null)
                    {
                        UIMethods.Write("   ");
                    }
                    else
                    {
                        UIMethods.Write($"{grid[i, j]}");
                    }
                    UIMethods.Write("|");
                }
                UIMethods.Write("\n");
                for (int j = 0; j < gridSize; j++)
                {
                    UIMethods.Write("+");
                    for (int k = 0; k < 3; k++)
                    {
                        UIMethods.Write("-");

                    }
                }
                UIMethods.Write("+");
                UIMethods.Write("\n");
            }
        }
    }
}
