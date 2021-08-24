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

        //public List<CurlyGhost> curlyGhostsLst() 
        //{
        //    cGhosts.Add(new CurlyGhost("C", ColorOfComponents.Red));
        //    cGhosts.Add(new CurlyGhost("C", ColorOfComponents.Blue));
        //    cGhosts.Add(new CurlyGhost("C", ColorOfComponents.Yellow));

        //    foreach (CurlyGhost ghost in cGhosts)
        //    {
                
        //    }

            
        //}

        int IGhost.MaxNumberOfGhosts
        {
            set 
            {
                if ((value > 0) && (value < 10))
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
            get => currentPosition;
        }
        
    }
}
