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
                UIMethods.WriteLine("Place your symbol.");
                userInput = UIMethods.ReadLine();
                UIMethods.WriteLine(userInput);

                UIMethods.OutputGrid(grid);
            }

        }
    }
}
