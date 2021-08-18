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

        private GameComponents gameComponents;
        private ColorOfComponents colorOfComponents;

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
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 4)
                        {
                            // Magenta Carpets
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            gameComponents = GameComponents.Portal;
                            colorOfComponents = ColorOfComponents.Red;
                            // Portal Magenta up
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            // Yellow Carpets
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow Room
                            gameComponents = GameComponents.Mirrow;

                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            // Magenta  carpets
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Red;
                        }

                        if (y == 1 || y == 3)
                        {
                            // blue carpets
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 4)
                        {
                            // Yellow Portal
                            colorOfComponents = ColorOfComponents.Yellow;
                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            // blue carpet
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 3)
                        {
                            gameComponents = GameComponents.Mirrow;
                        }

                        if (y == 2)
                        {
                            // Yellow carpet
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 4)
                        {
                            // Magenta 
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Red;
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            // yellow carpet
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 1)
                        {
                            // Magenta carpet
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Blue portal
                            gameComponents = GameComponents.Portal;
                            colorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 3)
                        {
                            // Blue carpet
                            gameComponents = GameComponents.Carpet;
                            colorOfComponents = ColorOfComponents.Blue;
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
