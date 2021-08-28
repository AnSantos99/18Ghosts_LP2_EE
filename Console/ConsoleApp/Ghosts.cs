using System;
using System.Collections.Generic;
using System.Collections;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class Ghosts
    {
        public ICollection<GhostsStructure> ghostsList;

        private ICollection<GhostsStructure> curlyGhost;
        private ICollection<GhostsStructure> roundGhost;


        public Ghosts() 
        {
            //ghostsList = new List<GhostsStructure>();
            curlyGhost = new List<GhostsStructure>();
            roundGhost = new List<GhostsStructure>();
        }

        public void GhostsSetUp(List<BoardStructureTiles> boardInfo) 
        {
            foreach (BoardStructureTiles item in boardInfo)
            {
                /*------------------------Curly Ghosts-----------------------*/
                if (item.ColorOfComponents == ColorOfComponents.Red &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure curlyGhostRed =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Red, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostRed);

                    item.GhostInBoard = curlyGhostRed;
                }

                if (item.ColorOfComponents == ColorOfComponents.Yellow &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure curlyGhostYellow =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Yellow, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostYellow);

                    item.GhostInBoard = curlyGhostYellow;
                }

                if (item.ColorOfComponents == ColorOfComponents.Blue &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure curlyGhostBlue =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Blue, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostBlue);

                    item.GhostInBoard = curlyGhostBlue;
                }

                /*------------------------Round Ghosts-----------------------*/
                if (item.ColorOfComponents == ColorOfComponents.Red &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure roundGhostRed =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Red, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    roundGhost.Add(roundGhostRed);

                    item.GhostInBoard = roundGhostRed;
                }

                if (item.ColorOfComponents == ColorOfComponents.Yellow &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure roundGhostYellow =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Yellow, new Position(
                        item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    roundGhost.Add(roundGhostYellow);

                    item.GhostInBoard = roundGhostYellow;
                }

                if (item.ColorOfComponents == ColorOfComponents.Blue &&
                    item.Components == GameComponents.Carpet)
                {
                    GhostsStructure roundGhostBlue =
                    new GhostsStructure(GhostType.CurlyGhost,
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
