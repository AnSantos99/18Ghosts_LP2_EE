using System.Collections.Generic;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class CurlyGhost : IGhost
    {
        // Determinate the maximal ghost available in the game.
        private int maxGhostPerPlyr = 9;

        private ColorOfComponents ghostColor;

        private Position currentPosition;

        ICollection<CurlyGhost> cGhosts;

        public CurlyGhost(string visualLook, ColorOfComponents ghostColor)
        {
            this.ghostColor = ghostColor;

            cGhosts = new List<CurlyGhost>(maxGhostPerPlyr);
        }

        int IGhost.MaxNumberOfGhosts
        {
            set 
            {
                if ((cGhosts.Count < 0) && (cGhosts.Count > 10))
                {
                    maxGhostPerPlyr = value;
                }
            }
        }

        ColorOfComponents IGhost.GhostColor 
        {
            get => ghostColor;
        } 

        Position IGhost.GhostPosition 
        { 
            // get currentposition of ghost?
            get => currentPosition;
        }
        
    }
}
