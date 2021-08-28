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
        BoardStructureTiles position;
        GameBoard pos;

        Random rnd;

        public Ghosts() 
        {
            //ghostsList = new List<GhostsStructure>();
            curlyGhost = new List<GhostsStructure>();
            pos = new GameBoard();
            rnd = new Random();
            position = new BoardStructureTiles();

        }



        

        public void GhostsSetUp(List<BoardStructureTiles> boardInfo) 
        {
            int xPos = position.PositionInBoard.XRow = pos.xPos;
            int yPos = position.PositionInBoard.YCol = pos.yPos;

            foreach (BoardStructureTiles item in boardInfo)
            {
                if (item.ColorOfComponents == ColorOfComponents.Red)
                {
                    GhostsStructure curlyGhostRed =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Red, new Position(xPos, yPos),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostRed);
                }

                if (item.ColorOfComponents == ColorOfComponents.Yellow)
                {
                    GhostsStructure curlyGhostYellow =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Yellow, new Position(item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostYellow);
                }

                if (item.ColorOfComponents == ColorOfComponents.Blue)
                {
                    GhostsStructure curlyGhostBlue =
                    new GhostsStructure(GhostType.CurlyGhost,
                    ColorOfComponents.Blue, new Position(item.PositionInBoard.XRow, item.PositionInBoard.YCol),
                        GameComponents.Carpet);

                    curlyGhost.Add(curlyGhostBlue);
                }
            }
        }
    }
}
