using System;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class Ghosts
    {
        public ICollection<GhostsStructure> ghostsList;

        public List<GhostsStructure> curlyGhost;

        public List<GhostsStructure> roundGhost;

        private int maxGhostInGame = 9;

        private int redGCounter = 1;
        private int blueGCounter = 1;
        private int yellowGCounter = 1;

        public Ghosts() 
        {
            //ghostsList = new List<GhostsStructure>();
            curlyGhost = new List<GhostsStructure>(maxGhostInGame);
            roundGhost = new List<GhostsStructure>(maxGhostInGame);

        }
        
        public void GhostsSetUp(List<BoardStructureTiles> boardInfo) 
        {
            

            foreach (BoardStructureTiles item in boardInfo)
            {
                /*------------------------Curly Ghosts-----------------------*/
                if (item.ColorOfComponents == ColorOfComponents.Red &&
                    item.Components == GameComponents.Carpet && item.GhostInBoard == null && redGCounter <= 3)
                {
                    GhostsStructure curlyGhostRed =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Red, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostRed);

                    item.GhostInBoard = curlyGhostRed;

                    redGCounter++;
                    break;
                }

                if (item.ColorOfComponents == ColorOfComponents.Yellow &&
                    item.Components == GameComponents.Carpet && item.GhostInBoard == null && yellowGCounter <= 3)
                {
                    GhostsStructure curlyGhostYellow =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Yellow, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostYellow);

                    item.GhostInBoard = curlyGhostYellow;

                    yellowGCounter++;
                    break;
                }

                if (item.ColorOfComponents == ColorOfComponents.Blue &&
                    item.Components == GameComponents.Carpet && 
                    item.GhostInBoard == null && blueGCounter <= 3)
                {
                    GhostsStructure curlyGhostBlue =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Blue, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostBlue);

                    item.GhostInBoard = curlyGhostBlue;

                    blueGCounter++;
                    break;
                }

                /*------------------------Round Ghosts-----------------------*/
                if (item.ColorOfComponents == ColorOfComponents.Red &&
                    item.Components == GameComponents.Carpet && item.GhostInBoard == null)
                {
                    GhostsStructure roundGhostRed =
                    new GhostsStructure(GhostType.RoundGhost,
                    ColorOfComponents.Red, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    roundGhost.Add(roundGhostRed);

                    item.GhostInBoard = roundGhostRed;

                    break;
                }

                if (item.ColorOfComponents == ColorOfComponents.Yellow &&
                    item.Components == GameComponents.Carpet && item.GhostInBoard == null)
                {
                    GhostsStructure roundGhostYellow =
                    new GhostsStructure(GhostType.RoundGhost,
                    ColorOfComponents.Yellow, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    roundGhost.Add(roundGhostYellow);

                    item.GhostInBoard = roundGhostYellow;
                }

                if (item.ColorOfComponents == ColorOfComponents.Blue &&
                    item.Components == GameComponents.Carpet && item.GhostInBoard == null)
                {
                    GhostsStructure roundGhostBlue =
                    new GhostsStructure(GhostType.RoundGhost,
                    ColorOfComponents.Blue, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    roundGhost.Add(roundGhostBlue);

                    item.GhostInBoard = roundGhostBlue;
                }
            }
        }
    }
}
