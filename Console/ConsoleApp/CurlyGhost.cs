using System.Collections.Generic;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class CurlyGhost : IGhost
    {
        // Determinate the maximal ghost available in the game.
        private int maxGhostInGame = 9;

        private ColorOfComponents ghostColor;

        private Position currentPosition;

        private Position nextPosition;


        ICollection<CurlyGhost> curlyGhosts;

        public CurlyGhost(ColorOfComponents ghostColor, GameBoard board, 
            Position ghostInBoardPosition)
        {
            this.ghostColor = ghostColor;

            curlyGhosts = new List<CurlyGhost>(maxGhostInGame);
        }

        int IGhost.MaxNumberOfGhosts
        {
            set 
            {
                if ((value > 0) && (value < 10))
                {
                    maxGhostInGame = value;
                }
            }
        }

        ColorOfComponents IGhost.GhostColor 
        {
            get => ghostColor;
        } 

        Position IGhost.GhostPosition 
        { 
            get => currentPosition;

            set 
            {
                value = currentPosition;

                if (value != currentPosition)
                {
                    nextPosition = value;
                }
            }
        }
        
    }
}
