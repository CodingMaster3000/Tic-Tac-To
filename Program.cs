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
            string gameWon = "";
            string gameTie = "";
            bool borderOrGrid;
            int[,] rowsAndCollumsPlayer0 = new int[2, GRID_SIZE];
            int[,] rowsAndCollumsPlayerX = new int[2, GRID_SIZE];
            string[,] grid = new string[GRID_SIZE, GRID_SIZE];
            string[,] gridBorder = new string[GRID_SIZE * 4 + 1, GRID_SIZE * 2 + 1];
            grid = Logic.InitializeGrid(grid, GRID_SIZE);
            gridBorder = Logic.ConstructGridBorder(gridBorder, GRID_SIZE);
            while (gameWon != "Winning Line!" && gameTie != "Tie!")
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
                    UIMethods.Write($"To place your symbol first choose a row. (1/.../{GRID_SIZE})\n");
                    userInputCollum = UIMethods.GetCoordinateInput(GRID_SIZE);
                    UIMethods.Write($"To place your symbol first choose a collum. (1/.../{GRID_SIZE})\n");
                    userInputRow = UIMethods.GetCoordinateInput(GRID_SIZE);
                    emptyCell = Logic.CheckCellContent(grid, userInputRow, userInputCollum);
                }
                grid[userInputRow, userInputCollum] = PLAYER_X_SYMBOL;
                gameWon = Logic.CheckForWinningLines(grid, userInputRow, userInputCollum, GRID_SIZE);
                UIMethods.Write($"{gameWon}");
                UIMethods.Write("\n");
                emptyCell = false;
                int randomCollum = 0;
                int randomRow = 0;
                while (!emptyCell)
                {
                    randomCollum = Logic.GenerateRAndomNumber(rng, GRID_SIZE);
                    randomRow = Logic.GenerateRAndomNumber(rng, GRID_SIZE);
                    emptyCell = Logic.CheckCellContent(grid, randomRow, randomCollum);
                }
                grid[randomRow, randomCollum] = PLAYER_0_SYMBOL;
                gameWon = Logic.CheckForWinningLines(grid, randomRow, randomCollum, GRID_SIZE);
                rowsAndCollumsPlayerX = Logic.AddMissingRowsAndLines(rowsAndCollumsPlayerX, userInputRow, userInputCollum);
                rowsAndCollumsPlayer0 = Logic.AddMissingRowsAndLines(rowsAndCollumsPlayer0, randomRow, randomCollum);
                gameTie = Logic.CheckForTie(rowsAndCollumsPlayerX, rowsAndCollumsPlayer0, GRID_SIZE);
                UIMethods.Write($"{gameWon} | {gameTie}");
                UIMethods.Write("\n");
            }
        }
    }
}