using System;
using System.Collections.Generic;
using System.Text;
namespace Tic_Tac_To
{
    public static class UIMethods
    {
        const int INPUT_TO_INDEX = 1;
        public static int GetCoordinateInput(int a)
        {
            int x = 0;
            bool correctInput = false;
            while (!correctInput || x <= 0 || x > 3)
            {
                string userInput = Console.ReadLine();
                correctInput = int.TryParse(userInput, out x);
                if (!correctInput)
                {
                    Write($"Invalid input. Make sure that the input is an integer bewteen 1 and {a}.");
                }
            }
            x -= INPUT_TO_INDEX;
            return x;
        }
        public static void Write(string text)
        {
            Console.Write($"{text}");
        }
    }
}
