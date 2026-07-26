namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int GRID_SIZE = 3;
            const int ADJUSTING_INDEX = 1;
            const string PLAYER_X_SYMBOL = "X";
            const string PLAYER_0_SYMBOL = "0";
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
                int userInputCollum = 0;
                int userInputRow = 0;
                bool emptyCell = false;
                while (!emptyCell)
                {
                    UIMethods.Write("To place your symbol first choose a row. (1/2/3)\n");
                    userInputCollum = UIMethods.GetCoordinateInput();
                    UIMethods.Write("To place your symbol first choose a collum. (1/2/3)\n");
                    userInputRow = UIMethods.GetCoordinateInput();
                    userInputRow--;
                    userInputCollum--;
                    emptyCell = Logic.CheckCellContent(grid, userInputRow, userInputCollum);
                }
                grid[userInputRow, userInputCollum] = PLAYER_X_SYMBOL;
                string gameState = Logic.CheckForWinningLines(grid, userInputRow, userInputCollum, GRID_SIZE);
                UIMethods.Write($"{gameState}");
                UIMethods.Write("\n");
                emptyCell = false;
                int randomCollum = 0;
                int randomRow = 0;
                while (!emptyCell)
                {
                    randomCollum = Logic.GenerateRAndomNumber(rng);
                    randomRow = Logic.GenerateRAndomNumber(rng);
                    emptyCell = Logic.CheckCellContent(grid, randomRow, randomCollum);
                }
                grid[randomRow, randomCollum] = PLAYER_0_SYMBOL;
                gameState = Logic.CheckForWinningLines(grid, randomRow, randomCollum, GRID_SIZE);
            }
        }
    }
}
