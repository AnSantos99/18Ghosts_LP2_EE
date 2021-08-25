using ConsoleApp.Model;
using ConsoleApp;
using System.Collections.Generic;
using System.Collections;

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

        // Create list of board structure features
        public List<BoardStructureTiles> boardTiles;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard() 
        {
            boardTiles = new List<BoardStructureTiles>();

            MAX_SPACE_X = 5;
            MAX_SPACE_Y = 5;

            // Setting up the max size for horizontal and vertical lines
            gameBoard = new GameBoard[MAX_SPACE_X, MAX_SPACE_Y];

            BoardStructure();
        }

        /// <summary>
        /// Setting up the structure of the board with its elements
        /// </summary>
        public void BoardStructure() 
        {
            for (int x = 0; x < MAX_SPACE_X; x++)
            {
                for (int y = 0; y < MAX_SPACE_Y; y++)
                {
                    // First row
                    if (x == 0)
                    {
                        // Blue
                        if (y == 0 || y == 3)
                        {
                            BoardStructureTiles blueCarpet = 
                                new BoardStructureTiles(GameComponents.Carpet, 
                                ColorOfComponents.Blue, new Position(x,y) );

                            boardTiles.Add(blueCarpet);
                        }

                        if (y == 1 || y == 4)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, new Position(x, y));

                            boardTiles.Add(redCarpet);
                        }

                        if (y == 2)
                        {
                            BoardStructureTiles redPortal =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Red, new Position(x, y));

                            boardTiles.Add(redPortal);
                        }
                    }

                    // Second row
                    if (x == 1)
                    {
                        if (y == 0 || y == 2 || y == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, new Position(x, y));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (y == 1 || y == 3)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Mirrow,
                                ColorOfComponents.nonExistent, new Position(x, y));

                            boardTiles.Add(yellowCarpet);
                        }
                    }

                    if (x == 2)
                    {
                        if (y == 0 || y == 2)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, new Position(x, y));

                            boardTiles.Add(redCarpet);
                        }

                        if (y == 1 || y == 3)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, new Position(x, y));

                            boardTiles.Add(blueCarpet);
                        }

                        if (y == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Yellow, new Position(x, y));

                            boardTiles.Add(yellowCarpet);

                        }
                    }

                    if (x == 3)
                    {
                        if (y == 0)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, new Position(x, y));

                            boardTiles.Add(blueCarpet);
                        }

                        if (y == 1 || y == 3)
                        {
                            BoardStructureTiles mirrow =
                                new BoardStructureTiles(GameComponents.Mirrow,
                                ColorOfComponents.nonExistent, new Position(x, y));

                            boardTiles.Add(mirrow);
                        }

                        if (y == 2)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, new Position(x, y));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (y == 4)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, new Position(x, y));

                            boardTiles.Add(redCarpet);
                        }
                    }

                    if (x == 4)
                    {
                        if (y == 0 || y == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, new Position(x, y));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (y == 1)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, new Position(x, y));

                            boardTiles.Add(redCarpet);
                        }

                        if (y == 2)
                        {
                            BoardStructureTiles bluePortal =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Blue, new Position(x, y));

                            boardTiles.Add(bluePortal);
                        }

                        if (y == 3)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, new Position(x, y));

                            boardTiles.Add(blueCarpet);
                        }
                    }
                }
            }
        }

        //public void PlayerExchange(Position currentPos, Player player) 
        //{
        //    switch (player)
        //    {
        //        case Player.Player1:
        //            gameBoard[currentPos.XRow, currentPos.YCol] = Player.Player1;
        //            break;
        //        case Player.Player2:
        //            gameBoard[currentPos.XRow, currentPos.YCol] = Player.Player2;
        //            break;
        //        default:
        //            break;
        //    }
        //}

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
