using System;

namespace ConsoleApp
{
    /// <summary>
    /// Class for the board structure
    /// </summary>
    class GameBoard
    {
        private int row;
        private int col;

        private string[,] board;

        public GameBoard(string[,] board)
        {
            this.board = board;

            // Save the length (row) of the bidemensional array into var row
            row = board.GetLength(0);

            // Save the length (col) of the bidemensional array into var col
            col = board.GetLength(1);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DrawGameBoard()
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    string grid = board[x, y];

                    // Inverted logic because this methods parameters request
                    // the left = column and top = row.
                    Console.SetCursorPosition(y, x);
                    Console.Write(grid);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool ValidPositionCheck(int x, int y)
        {
            // To not be able to go to the limits of the board
            if (x < 0 || y < 0 || x >= col || y >= row)
                return false;

            // To check the valid positions on the board
            return board[x, y] == "  ";
        }
    }
}
