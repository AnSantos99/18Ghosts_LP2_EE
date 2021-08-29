using System;
using ConsoleApp.Model;

namespace ConsoleApp.Model
{
    class Movement
    { 
        private GhostsStructure currentGhost; 
        private BoardStructureTiles tiles;

        public Movement()
        {
            tiles = new BoardStructureTiles();
            currentGhost = new GhostsStructure();
        }
        public void PickUpGhost( )
        {

        }

        /// <summary>
        /// Piece movement for ghosts after choosing a ghost from board
        /// </summary>
        public void PieceMovement()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey(true);
            ConsoleKey pressedKey = consoleKey.Key;

            switch (pressedKey)
            {
                case ConsoleKey.W:
                    if (ValidTileCheck())
                    {
                        currentGhost.GhostPosition.YCol -= 1;
                    }
                    break;

                case ConsoleKey.A:
                    if (ValidTileCheck())
                    {
                        currentGhost.GhostPosition.XRow -= 1;
                    }
                    break;

                case ConsoleKey.D:
                    if (ValidTileCheck())
                    {
                        currentGhost.GhostPosition.XRow += 1;
                    }
                    break;

                case ConsoleKey.S:
                    if (ValidTileCheck())
                    {
                        currentGhost.GhostPosition.YCol += 1;
                    }
                    break;

                default:
                    break;
            }
        }

        private bool ValidTileCheck()
        {
            //tiles = new BoardStructureTiles(); ????????
            // To not be able to go to the limits of the board
            if (tiles.Components == GameComponents.Borders ||
               tiles.Components == GameComponents.Portal ||
               tiles.Components == GameComponents.Dungeon)
                return false;

            // To check the valid positions on the board
            return tiles.Components == GameComponents.Carpet ||
                tiles.Components == GameComponents.Mirrow;
        }
    }
}
