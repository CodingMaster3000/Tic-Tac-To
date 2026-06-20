using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_To
{
    public static class UIMethods
    {

        public static void OutputGrid(string[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == null)
                    {
                        Console.Write("-");
                    }
                }
            }    
        }

        public static string ReadLine ()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void WriteLine(string text)
        {
            Console.WriteLine($"{text}");
        }
    }
}
