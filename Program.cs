namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE = 3;
            string userInput;
            int[,] grid = new int[GRID_SIZE, GRID_SIZE];
            UIMethods.WriteLine("Place your symbol.");
            userInput = UIMethods.ReadLine();
            UIMethods.WriteLine(userInput);

            UIMethods.OutputGrid(grid);
        }
    }
}
