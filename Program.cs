namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE = 3;
            int[,] grid = new int[GRID_SIZE, GRID_SIZE];
            UIMethods.OutputGrid(grid);
        }
    }
}
