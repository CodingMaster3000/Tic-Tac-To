namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE = 3;
            string userInput;
            string[,] grid = new string[GRID_SIZE, GRID_SIZE];
            while (true)
            {
                UIMethods.Write("Place your symbol.");
                userInput = UIMethods.ReadLine();
                UIMethods.Write(userInput);
                UIMethods.Write("\n");

                Logic.CheckGrid(grid,GRID_SIZE);
            }

        }
    }
}
