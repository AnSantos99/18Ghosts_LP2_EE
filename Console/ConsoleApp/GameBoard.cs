using System;

namespace ConsoleApp
{
    /// <summary>
    /// Class for the board structure
    /// </summary>
    class GameBoard
    {

        private readonly Position boardPos;

        private Position currentBoardPos;

        private string[,] board;

        private string portal = "U";

        public GameBoard(string[,] board)
        {
            this.board = board;
            boardPos = new Position();

            // Save the length (row) of the bidemensional array into var row
            boardPos.XRow = board.GetLength(0);

            // Save the length (col) of the bidemensional array into var col
            boardPos.YCol = board.GetLength(1);

            PortalPositioning(board);
        }

        private void PortalPositioning(string[,] board) 
        {
            board[1, 8] = portal;
            board[5, 11] = portal;
            board[9, 8] = portal;
        }

        private void DungeonSpace(string[,] board)
        {
            //board[2, 4] = mirrow;

            
            //board[] = mirrow;
            //board[] = mirrow;
            //board[] = mirrow;

        }

        /// <summary>
        /// 
        /// </summary>
        public void DrawGameBoard()
        {
            for (int x = 0; x < boardPos.XRow; x++)
            {
                for (int y = 0; y < boardPos.YCol; y++)
                {
                    string grid = board[x, y];

                    // Inverted logic because this methods parameters request
                    // the left = column and top = row.
                    Console.SetCursorPosition(y, x);

                    Console.Write(board[x, y]);
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
            if (x < 0 || y < 0 || x >= boardPos.YCol || y >= boardPos.XRow ||
                board[x, y] == "U" || board[x, y] == "─" || board[x, y] == "│")
                return false;

            // To check the valid positions on the board
            return board[x, y] == " " || board[x, y] == "▒";
        }
    }
}
