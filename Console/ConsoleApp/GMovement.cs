using System;
using System.Collections.Generic;
using System.Text;

namespace RecursoLP2_PPT
{
    class GMovement
    {
        private GameBoard[,] board;

        private IGhost currentGhost;

        public Movement(GameBoard[,] board)
        {
            this.board = board;

        }

        public void PickUpGhost()
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
                    currentGhost.GhostPosition.YCol -= 1;
                    break;
                case ConsoleKey.A:
                    currentGhost.GhostPosition.XRow -= 1;
                    break;
                case ConsoleKey.D:
                    currentGhost.GhostPosition.XRow += 1;
                    break;
                case ConsoleKey.S:
                    currentGhost.GhostPosition.YCol += 1;
                    break;

                default:
                    break;
            }
        }
    }
}
