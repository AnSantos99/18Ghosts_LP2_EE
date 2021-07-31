using System;

namespace ConsoleApp
{
    /// <summary>
    /// Class for the board structure
    /// </summary>
    class GameBoard
    {
        private Position row;
        private Position col;

        private string[,] board;

        private string portal = "U";
        private const string mirrow = "█";

        Random rnd;

        public GameBoard(string[,] board)
        {
            this.board = board;
            row = new Position();
            col = new Position();

            // Save the length (row) of the bidemensional array into var row
            row.XRow = board.GetLength(0);

            // Save the length (col) of the bidemensional array into var col
            col.YCol = board.GetLength(1);

            PortalPositioning(board);

            DungeonSpace(board);

            
        }

        private void PortalPositioning(string[,] board) 
        {
            
            board[1, 5] = portal;
            board[5, 9] = portal;
            board[9, 5] = portal;
        }

        private void DungeonSpace(string[,] board)
        {
            rnd = new Random();
            board[2, 4] = mirrow;

            
            //board[] = mirrow;
            //board[] = mirrow;
            //board[] = mirrow;

        }

        /// <summary>
        /// 
        /// </summary>
        public void DrawGameBoard()
        {
            for (int x = 0; x < row.XRow; x++)
            {
                for (int y = 0; y < col.YCol; y++)
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
            if (x < 0 || y < 0 || x >= col.YCol || y >= row.XRow)
                return false;

            // To check the valid positions on the board
            return board[x, y] == "  " || board[x, y] == "▒▒";
        }
    }
}
