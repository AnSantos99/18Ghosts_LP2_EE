using System;

namespace ConsoleApp.Model
{
    class Board
    {
        private string[,] gameBoard;

        private Position boardPos;

        GameFeatures features;

        public Board(string[,] gameBoard) 
        {
            this.gameBoard = gameBoard;
            boardPos = new Position();
        }

        public void BoardStructure() 
        {
            gameBoard = new string[5,5];

            int xCord = boardPos.XRow = gameBoard.GetLength(0);
            int yCord = boardPos.YCol = gameBoard.GetLength(1);

            for (int x = 0; x < xCord; x++)
            {
                for (int y = 0; y < yCord; y++)
                {
                    Console.Write("| " + gameBoard[x,y]);
                }
            }
        }
    }
}
