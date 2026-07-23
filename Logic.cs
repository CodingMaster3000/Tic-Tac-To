using System;
using System.Collections.Generic;
using System.Text;
namespace Tic_Tac_To
{
    public static class Logic
    {
        public static string[,] ConstructGridBorder(string[,] gridBorder, int gridSize)
        {
            for (int j = 0; j < gridSize * 4 + 1; j++)
            {
                if (j == 0 || j % 4 == 0)
                {
                    gridBorder[j, 0] = "+";
                }
                else
                {
                    gridBorder[j, 0] = "-";
                }
            }
            for (int i = 1; i < gridSize * 2 + 1; i++)
            {
                if (i == 1 || i % 2 != 0)
                {
                    for (int j = 0; j < gridSize * 4 + 1; j++)
                    {
                        if (j == 0 || j % 4 == 0)
                        {
                            gridBorder[j, i] = "|";
                        }
                        else
                        {
                            gridBorder[j, i] = " ";
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < gridSize * 4 + 1; j++)
                    {
                        if (j == 0 || j % 4 == 0)
                        {
                            gridBorder[j, i] = "+";
                        }
                        else
                        {
                            gridBorder[j, i] = "-";
                        }
                    }
                }
            }
            return gridBorder;
        }
        public static string[,] InitializeGrid(string[,] grid, int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[j, i] = " ";
                }
            }
            return grid;
        }
        public static bool CheckCoordinates(int a, int b)
        {
            return (a + 2) % 4 == 0 && (b + 1) % 2 == 0;
        }
        public static string[,] MakeAIMove(string[,] grid, Random rng)
        {
            while (true)
            {
                int randomCollum = rng.Next(0, 2);
                int randomRow = rng.Next(0, 2);
                if (grid[randomCollum, randomRow] == " ")
                {
                    grid[randomCollum, randomRow] = "O";
                    break;
                }
            }
            return grid;
        }
        public static bool CheckCellContent(string[,] grid, int a, int b)
        {
            if (grid[a, b] == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string CheckForWinningLines(string[,] grid, int a, int b, int c)
        {
            bool winningLineFound = false;
            for (int i = -1; i < 1; i++)
            {
                try
                {
                    if (grid[a, b] == grid[a - 1, b + i])
                    {
                        winningLineFound = FollowTheLine(grid, a, b, a, b, i);
                        if (winningLineFound)
                        {
                            return "Winning Line!";
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
                try
                {
                    if (grid[a, b] == grid[a + 1, b + i])
                    {
                        winningLineFound = FollowTheLine(grid, a, b, a, b, i);
                        if (winningLineFound)
                        {
                            return "Winning Line!";
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
            for (int i = -1; i < 1; i += 2)
            {
                try
                {
                    if (grid[a, b] == grid[a, b + i])
                    {
                        winningLineFound = FollowTheLine(grid, a, b, a, b, i);
                        if (winningLineFound)
                        {
                            return "Winning Line!";
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
            if (winningLineFound)
            {
                return "Winning Line!";
            }
            else
            {
                return "No Winning Line!";
            }
        }
        public static bool FollowTheLine(string[,] grid, int a, int b, int d, int e, int f)
        {
            d--;
            e += f;
            while (0 <= d && d <= 2 && 0 <= e && e <= 2)
            {

                if (grid[a, b] != grid[d, e])
                {
                    return false;
                }
                d--;
                e += f;
            }
            d = a;
            e = b;
            while (0 <= d && d <= 2 && 0 <= e && e <= 2)
            {

                if (grid[a, b] != grid[d, e])
                {
                    return false;
                }
                d--;
                e += f;
            }
            return true;
        }
    }
}
