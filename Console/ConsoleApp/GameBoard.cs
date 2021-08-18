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

        private BoardStructure size;

        // Set the maximum size for the board size.
        private int MAX_SPACE_X;
        private int MAX_SPACE_Y;

        private GameComponents gameComponents;
        private ColorOfComponents colorOfComponents;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard(BoardStructure[,] gameBoard) 
        {
            MAX_SPACE_X = size.Position.XRow = 5;
            MAX_SPACE_Y = size.Position.YCol = 5;

            this.gameBoard = gameBoard;

            gameBoard = new BoardStructure[MAX_SPACE_X, MAX_SPACE_Y];
        }

        /// <summary>
        /// Setting up the structure of the board with its elements
        /// </summary>
        public void BoardStructure() 
        {
            for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
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
