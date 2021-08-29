﻿using ConsoleApp.Model;
using System.Collections.Generic;

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

        public DungeonStructure[,] dungeonStructure;

        // Set the maximum size for the board size. This value will never change
        // Setting up maximum capacity of the x and y coordinates for board
        private const int MAX_SPACE_X = 5;
        private const int MAX_SPACE_Y = 5;

        public const int MAX_SPACE_X_DUNGEON = 3;
        public const int MAX_SPACE_Y_DUNGEON = 6;


        //private Ghosts ghost;

        private Ghosts ghost;

        
        public int xPos, yPos;

        // Create list of board structure features
        public List<BoardStructureTiles> boardTiles;

        /// <summary>
        /// Setting up the gameboard.
        /// </summary>
        public GameBoard() 
        {
            boardTiles = new List<BoardStructureTiles>();
            ghost = new Ghosts();

            
            // Setting up the max size for horizontal and vertical lines
            gameBoard = new GameBoard[MAX_SPACE_X, MAX_SPACE_Y];

            dungeonStructure = new DungeonStructure[2,10];
        }

        

        /// <summary>
        /// Setting up the structure of the board with its elements
        /// </summary>
        public void BoardStructure() 
        {
            for (xPos = 0; xPos < MAX_SPACE_X; xPos++)
            {
                for (yPos = 0; yPos < MAX_SPACE_Y; yPos++)
                {
                    // First row
                    if (xPos == 0)
                    {
                        // Blue carpets
                        if (yPos == 0 || yPos == 3)
                        {
                            BoardStructureTiles blueCarpet = 
                                new BoardStructureTiles(GameComponents.Carpet, 
                                ColorOfComponents.Blue, new Position(xPos, yPos));

                            boardTiles.Add(blueCarpet);
                        }

                        // Red carpets
                        if (yPos == 1 || yPos == 4)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, new Position(xPos, yPos));

                            boardTiles.Add(redCarpet);
                        }

                        // Red portal
                        if (yPos == 2)
                        {
                            BoardStructureTiles redPortal =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Red, new Position(xPos, yPos));

                            boardTiles.Add(redPortal);
                        }
                    }

                    // Second row
                    if (xPos == 1)
                    {
                        // yellow carpet
                        if (yPos == 0 || yPos == 2 || yPos == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, new Position(xPos, yPos));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (yPos == 1 || yPos == 3)
                        {
                            BoardStructureTiles mirrow =
                                new BoardStructureTiles(GameComponents.Mirrow,
                                ColorOfComponents.nonExistent, new Position(xPos, yPos));
                            // Add method of mirrow comportamento

                            boardTiles.Add(mirrow);
                        }
                    }

                    if (xPos == 2)
                    {
                        if (yPos == 0 || yPos == 2)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, 
                                new Position(xPos, yPos));

                            boardTiles.Add(redCarpet);
                        }

                        if (yPos == 1 || yPos == 3)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, 
                                new Position(xPos, yPos));

                            boardTiles.Add(blueCarpet);
                        }

                        if (yPos == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Yellow, new Position(xPos, yPos));

                            boardTiles.Add(yellowCarpet);
                        }
                    }

                    if (xPos == 3)
                    {
                        if (yPos == 0)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, 
                                new Position(xPos, yPos));

                            boardTiles.Add(blueCarpet);
                        }

                        if (yPos == 1 || yPos == 3)
                        {
                            BoardStructureTiles mirrow =
                                new BoardStructureTiles(GameComponents.Mirrow,
                                ColorOfComponents.nonExistent, 
                                new Position(xPos, yPos));

                            // Add method of mirrow comportamento

                            boardTiles.Add(mirrow);
                        }

                        if (yPos == 2)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, 
                                new Position(xPos, yPos));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (yPos == 4)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, 
                                new Position(xPos, yPos));

                            boardTiles.Add(redCarpet);
                        }
                    }

                    if (xPos == 4)
                    {
                        if (yPos == 0 || yPos == 4)
                        {
                            BoardStructureTiles yellowCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Yellow, 
                                new Position(xPos, yPos));

                            boardTiles.Add(yellowCarpet);
                        }

                        if (yPos == 1)
                        {
                            BoardStructureTiles redCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Red, 
                                new Position(xPos, yPos));

                            boardTiles.Add(redCarpet);
                        }

                        if (yPos == 2)
                        {
                            BoardStructureTiles bluePortal =
                                new BoardStructureTiles(GameComponents.Portal,
                                ColorOfComponents.Blue, 
                                new Position(xPos, yPos));

                            boardTiles.Add(bluePortal);
                        }

                        if (yPos == 3)
                        {
                            BoardStructureTiles blueCarpet =
                                new BoardStructureTiles(GameComponents.Carpet,
                                ColorOfComponents.Blue, 
                                new Position(xPos, yPos));

                            boardTiles.Add(blueCarpet);
                        }
                    }
                    ghost.GhostsSetUp(boardTiles);
                }
            }
        }

        /// <summary>
        /// Setting up the dungeon structure
        /// </summary>
        //public void DungeonStructure()
        //{
        //    for (int x = 0; x < MAX_SPACE_X_DUNGEON; x++)
        //    {
        //        for (int y = 0; y < MAX_SPACE_Y_DUNGEON; y++)
        //        {
        //            dungeonStructure[x, y] = new DungeonStructure();
        //        }
        //    }
        //}

        public void CheckTiles() 
        {

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
        
    }
}
