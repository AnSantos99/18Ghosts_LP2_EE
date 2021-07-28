using System;

namespace ConsoleApp
{
    /// <summary>
    /// Class to specify structure of gameboard and to draw it.
    /// </summary>
    class GameBoard
    {
        private string[,] boardStructure =
        {
            { "╔", "══", "╦═", "═","╦═", "═","╦═", "═","╦═", "═", "╦════╗" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╚", "══", "╩═", "═","╩═", "═","╩", "══","╩═", "═", "╩════╝" }
        };

        public void DrawBoard() 
        {
            // Save the length (row) of the bidemensional array into var row
            int row = boardStructure.GetLength(0);

            // Save the length (col) of the bidemensional array into var col
            int col = boardStructure.GetLength(1);

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    string grid = boardStructure[x, y];

                    // Inverted logic because this methods parameters request
                    // the left = column and top = row.
                    Console.SetCursorPosition(y, x);
                    Console.Write(grid);
                }
            }
        }

    }
}
