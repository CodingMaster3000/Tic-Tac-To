namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int GRID_SIZE = 3;
            const int ADJUSTING_INDEX = 1;
            int userInputCollum;
            int userInputRow;
            bool borderOrGrid;
            string[,] grid = new string[GRID_SIZE, GRID_SIZE];
            string[,] gridBorder = new string[GRID_SIZE * 4 + 1, GRID_SIZE * 2 + 1];
            grid = Logic.InitializeGrid(grid, GRID_SIZE);
            gridBorder = Logic.ConstructGridBorder(gridBorder, GRID_SIZE);
            while (true)
            {
                for (int i = 0; i < GRID_SIZE * 2 + 1; i++)
                {
                    for (int j = 0; j < GRID_SIZE * 4 + 1; j++)
                    {
                        borderOrGrid = Logic.CheckCoordinates(j, i);
                        if (borderOrGrid)
                        {
                            UIMethods.Write($"{grid[(j - 2) / 4, (i - 1) / 2]}");
                        }
                        else
                        {
                            UIMethods.Write($"{gridBorder[j, i]}");
                        }
                        //UIMethods.Write($"{gridBorder[j, i]}");
                    }
                    UIMethods.Write("\n");
                }
                UIMethods.Write("To place your symbol first choose a row. (1/2/3)\n");
                userInputCollum = Convert.ToInt32(UIMethods.GetCoordinateInput());
                UIMethods.Write("To place your symbol first choose a collum. (1/2/3)\n");
                userInputRow = Convert.ToInt32(UIMethods.GetCoordinateInput());
                grid[userInputCollum - ADJUSTING_INDEX, userInputRow - ADJUSTING_INDEX] = "X";
                UIMethods.Write("\n");
                grid = Logic.MakeAIMove(grid, rng);
            }
        }
    }
}
