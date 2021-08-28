using ConsoleApp.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApp.View
{
    class ViewGhosts
    {
        private GameBoard board;

        private const string curlyGhost = "AAAA";
        private const string roundGhost = "●";

        private Ghosts ghosts;

        public ViewGhosts() 
        {
            board = new GameBoard();
            ghosts = new Ghosts();
        }

        public void DrawGhost() 
        {
            foreach (GhostsStructure item in ghosts.ghostsList)
            {
                if (item.GhostType == GhostType.CurlyGhost)
                {
                    Console.Write(curlyGhost);
                }

                if (item.GhostType == GhostType.RoundGhost)
                {
                    Console.Write(roundGhost);
                }

                if (item.GhostColor == ColorOfComponents.Blue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (item.GhostColor == ColorOfComponents.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (item.GhostColor == ColorOfComponents.Yellow)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.ResetColor();
            }  
        }
    } 
}
