using System;
using ConsoleApp.Model;

namespace ConsoleApp
{
    /// <summary>
    /// Class for the board structure
    /// </summary>
    class GameBoard
    {
        /// <summary>
        /// Create a board.
        /// </summary>
        private BoardStructure[,] gameBoard;

        // Set the maximum size for the board size.
        private const int MAX_SPACE = 5;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard() 
        {
            gameBoard = new BoardStructure[MAX_SPACE, MAX_SPACE];
        }

        /// <summary>
        /// Setting up the structure of the board with its elements
        /// </summary>
        public void BoardStructure() 
        {
            for (int x = 0; x < MAX_SPACE; x++)
            {
                for (int y = 0; y < MAX_SPACE; y++)
                {
                    // First row
                    if (x == 0)
                    {
                        // Blue
                        if (y == 0 || y == 3)
                        {
                            //Blue carpets
                        }

                        if (y == 1 || y == 4)
                        {
                            // Magenta Carpets
                        }

                        if (y == 2)
                        {
                            // Portal Magenta up
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            // Yellow Carpets
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow Room
                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            // Magenta  carpets
                        }

                        if (y == 1 || y == 3)
                        {
                            // blue carpets
                        }

                        if (y == 4)
                        {
                            // Yellow Portal
                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            // blue carpet
                        }

                        if (y == 1 || y == 3 || y == 4)
                        {
                            // Magenta carpets
                        }

                        if (y == 2)
                        {
                            // Yellow carpet
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            // yellow carpet
                        }

                        if (y == 1)
                        {
                            // Magenta carpet
                        }

                        if (y == 2)
                        {
                            // Blue portal
                        }

                        if (y == 3)
                        {
                            // Blue carpet
                        }
                    }
                }
            }
        }

        //private readonly Position boardPos;

        //private Position currentBoardPos;

        //private string[,] board;

        //private string portal = "U";

        //public GameBoard(string[,] board)
        //{
        //    this.board = board;
        //    boardPos = new Position();

        //    // Save the length (row) of the bidemensional array into var row
        //    boardPos.XRow = board.GetLength(0);

        //    // Save the length (col) of the bidemensional array into var col
        //    boardPos.YCol = board.GetLength(1);

        //    PortalPositioning(board);
        //}

        //private void PortalPositioning(string[,] board) 
        //{
        //    board[1, 8] = portal;
        //    board[5, 11] = portal;
        //    board[9, 8] = portal;
        //}

        //private void DungeonSpace(string[,] board)
        //{
        //    //board[2, 4] = mirrow;

            
        //    //board[] = mirrow;
        //    //board[] = mirrow;
        //    //board[] = mirrow;

        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public void DrawGameBoard()
        //{
        //    for (int x = 0; x < boardPos.XRow; x++)
        //    {
        //        for (int y = 0; y < boardPos.YCol; y++)
        //        {
        //            string grid = board[x, y];

        //            // Inverted logic because this methods parameters request
        //            // the left = column and top = row.
        //            Console.SetCursorPosition(y, x);

        //            Console.Write(board[x, y]);
        //        }
        //    }
        //}



        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="x"></param>
        ///// <param name="y"></param>
        ///// <returns></returns>
        //public bool ValidPositionCheck(int x, int y)
        //{
        //    // To not be able to go to the limits of the board
        //    if (x < 0 || y < 0 || x >= boardPos.YCol || y >= boardPos.XRow ||
        //        board[x, y] == "U" || board[x, y] == "─" || board[x, y] == "│")
        //        return false;

        //    // To check the valid positions on the board
        //    return board[x, y] == " " || board[x, y] == "▒";
        //}
    }
}
