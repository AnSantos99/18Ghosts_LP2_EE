using ConsoleApp.Model;

namespace ConsoleApp
{
    /// <summary>
    /// Class that handles the board structure by setting up its components
    /// for each position on the dimensional array 
    /// </summary>
    class GameBoard
    {
        /// <summary>
        /// Create a board.
        /// </summary>
        public GameBoard[,] gameBoard;

        // Set the maximum size for the board size.
        private int MAX_SPACE_X;
        private int MAX_SPACE_Y;

        private GameComponents components;
        private ColorOfComponents colorOfComponents;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard() 
        {
            MAX_SPACE_X = 5;
            MAX_SPACE_Y = 5;

            // Setting up the max size for horizontal and vertical lines
            gameBoard = new GameBoard[MAX_SPACE_X, MAX_SPACE_Y];
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
                            // Blue Carpet
                            components = GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 4)
                        {
                            // Red Carpet
                            components = GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Red Portal
                            components = GameComponents.Portal;
                            colorOfComponents = 
                                ColorOfComponents.Red;
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            // Yellow Carpets
                            components = GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow Room
                            components = GameComponents.Mirrow;
                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            // Red carpets
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Blue carpets
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 4)
                        {
                            // Yellow Portal
                            colorOfComponents= 
                                ColorOfComponents.Yellow;
                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            // Blue carpet
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow room
                            components = 
                                GameComponents.Mirrow;
                        }

                        if (y == 2)
                        {
                            // Yellow carpets
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents= 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 4)
                        {
                            // Red carpet
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents= 
                                ColorOfComponents.Red;
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            // Yellow carpet
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 1)
                        {
                            // Red carpet
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Blue portal
                            components = 
                                GameComponents.Portal;
                            colorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 3)
                        {
                            // Blue carpet
                            components = 
                                GameComponents.Carpet;
                            colorOfComponents = 
                                ColorOfComponents.Blue;
                        }
                    }
                }
            }
        }

        public void CheckForEmptyRooms() 
        {

        }

        public bool CheckValidPosition() 
        {
            return true;
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
