using System;

namespace ConsoleApp.Model
{
    class Movement
    {
        private GameBoard[,] board;
        private GhostsStructure currentGhost;
        public Position PositionInBoard;
        private GameComponents Components;

        public Movement(GameBoard[,] board, GhostsStructure currentGhost, 
            Position PositionInBoard, GameComponents Components)
        {
            this.board = board;
            this.currentGhost = currentGhost;
            this.PositionInBoard = PositionInBoard;
            this.Components = Components;
        }

        public void PickUpGhost(GhostsStructure currentGhost)
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
                    currentGhost.GhostPosition.YCol -= 1;
                    break;

                default:
                    break;
            }
        }

        public void MoveVerification()
        {
            if (board.PositionInBoard(GhostPosition.XRow, GhostPosition.YCol - 1))
            {
                currentGhost.GhostPosition.YCol -= 1;
            }
            if (board.PositionInBoard(GhostPosition.XRow, GhostPosition.YCol - 1))
            {
                currentGhost.GhostPosition.YCol -= 1;
            }
            if (board.PositionInBoard(GhostPosition.XRow, GhostPosition.YCol - 1))
            {
                currentGhost.GhostPosition.YCol -= 1;
            }
            if (board.PositionInBoard(GhostPosition.XRow, GhostPosition.YCol - 1))
            {
                currentGhost.GhostPosition.YCol -= 1;
            }
        }
      
        }

    }
 