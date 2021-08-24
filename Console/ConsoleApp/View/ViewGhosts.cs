using System;
using System.Collections.Generic;
using ConsoleApp.Model;

namespace ConsoleApp.View
{
    class ViewGhosts
    {
        private ICollection<CurlyGhost> curlyGhostLst;

        private const string CURLY_GHOST = "C";

        private GameBoard board;

        private Random rnd;

        private int randomPos;

        public ViewGhosts() 
        {
            board = new GameBoard();
            //curlyGhostLst = new List<CurlyGhost>();
            rnd = new Random();
        }

        public void DrawGhostInBoardRandom() 
        { 
            //curlyGhostLst.Add(new CurlyGhost(CURLY_GHOST, ColorOfComponents.Red));
            //curlyGhostLst.Add(new CurlyGhost(CURLY_GHOST, ColorOfComponents.Blue));
            //curlyGhostLst.Add(new CurlyGhost(CURLY_GHOST, ColorOfComponents.Yellow));

           
            for (int i = 0; i < board.gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.gameBoard.GetLength(1); j++)
                {
                    if (i == 1 && j == 1 || i == 3 && j == 1 ||
                    i == 1 && j == 3 || i == 3 && j == 3)
                    {
                        Console.Write("HAA");
                    }
                        
                }
            }
            

        }
    }
}
