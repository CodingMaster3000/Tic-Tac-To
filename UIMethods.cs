using System;
using System.Collections.Generic;
using System.Text;
namespace Tic_Tac_To
{
    public static class UIMethods
    {
        public static int GetCoordinateInput()
        {
            int x = 0;
            bool correctInput = false;
            bool falseInput = false;
            
            while (correctInput == false || x <= 0 || x > 3)
            {
                
                string userInput = Console.ReadLine();
                correctInput = int.TryParse(userInput, out x);

            }
            return x;


        }
        public static void Write(string text)
        {
            Console.Write($"{text}");
        }
    }
}
