using System;
using System.Collections.Generic;
using System.Text;
namespace Tic_Tac_To
{
    public static class UIMethods
    {
        public static string GetCoordinateInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void Write(string text)
        {
            Console.Write($"{text}");
        }
    }
}
