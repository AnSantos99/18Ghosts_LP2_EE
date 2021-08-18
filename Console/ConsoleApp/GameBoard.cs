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

            // Setting up the max size for horizontal and vertical lines
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
                            // Blue Carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 4)
                        {
                            // Red Carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Red Portal
                            gameComponents.GameComponent = 
                                GameComponents.Portal;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            // Yellow Carpets
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow Room
                            gameComponents.GameComponent = 
                                GameComponents.Mirrow;
                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            // Red carpets
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Blue carpets
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 4)
                        {
                            // Yellow Portal
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Yellow;
                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            // Blue carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 1 || y == 3)
                        {
                            // Mirrow room
                            gameComponents.GameComponent = 
                                GameComponents.Mirrow;
                        }

                        if (y == 2)
                        {
                            // Yellow carpets
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 4)
                        {
                            // Red carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            // Yellow carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Yellow;
                        }

                        if (y == 1)
                        {
                            // Red carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Red;
                        }

                        if (y == 2)
                        {
                            // Blue portal
                            gameComponents.GameComponent = 
                                GameComponents.Portal;
                            colorOfComponents.ColorOfComponents = 
                                ColorOfComponents.Blue;
                        }

                        if (y == 3)
                        {
                            // Blue carpet
                            gameComponents.GameComponent = 
                                GameComponents.Carpet;
                            colorOfComponents.ColorOfComponents = 
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
