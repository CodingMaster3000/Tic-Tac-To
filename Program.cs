namespace Tic_Tac_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GRID_SIZE = 3;
            const int ADJUSTING_INDEX = 1;
            int userInputCollum;
            int userInputRow;
            string[,] grid = new string[GRID_SIZE, GRID_SIZE];
            while (true)
            {
                UIMethods.Write("To place your symbol first choose a collum. (1/2/3)\n");
                userInputCollum = Convert.ToInt32(UIMethods.ReadLine());
                UIMethods.Write("To place your symbol first choose a row. (1/2/3)\n");
                userInputRow = Convert.ToInt32(UIMethods.ReadLine());
                grid[userInputCollum-ADJUSTING_INDEX, userInputRow-ADJUSTING_INDEX] = " X ";
                UIMethods.Write("\n");

                Logic.CheckGrid(grid,GRID_SIZE);
            }

        }
    }
}
