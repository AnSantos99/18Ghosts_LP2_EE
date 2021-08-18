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
        public BoardStructure[,] gameBoard;

        // Set the maximum size for the board size.
        private int MAX_SPACE_X;
        private int MAX_SPACE_Y;

        // Get Gamecomponents through boardstruture class
        private BoardStructure gameComponents;

        // Get Color of the components through boarstructure class
        private BoardStructure colorOfComponents;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard() 
        {
            gameComponents = new BoardStructure();
            colorOfComponents = new BoardStructure();

            MAX_SPACE_X = 5;
            MAX_SPACE_Y = 5;

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
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 4)
                        {
                            // Magenta Carpets
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            gameComponents.GameComponent = 
                                GameComponents.Portal;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                            // Portal Magenta up
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            // Yellow Carpets
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow Room
                            gameComponents.GameComponent = GameComponents.Mirrow;

                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            // Magenta  carpets
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Red;
                        }

                        if (y == 1 || y == 3)
                        {
                            // blue carpets
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 4)
                        {
                            // Yellow Portal
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Yellow;
                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            // blue carpet
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 3)
                        {
                            gameComponents.GameComponent = GameComponents.Mirrow;
                        }

                        if (y == 2)
                        {
                            // Yellow carpet
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 4)
                        {
                            // Magenta 
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Red;
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            // yellow carpet
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Yellow;
                        }

                        if (y == 1)
                        {
                            // Magenta carpet
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Blue portal
                            gameComponents.GameComponent = GameComponents.Portal;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Blue;
                        }

                        if (y == 3)
                        {
                            // Blue carpet
                            gameComponents.GameComponent = GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = ColorOfComponents.Blue;
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
