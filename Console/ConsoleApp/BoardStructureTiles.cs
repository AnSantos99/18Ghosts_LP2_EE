using ConsoleApp.Model;

namespace ConsoleApp
{
    class BoardStructureTiles
    {

        
        public GameComponents Components { get; set; }

        public ColorOfComponents ColorOfComponents { get; set; }

        public Position PositionInBoard { get; set; }

        public IGhost GhostInBoard { get; set; }

        public BoardStructureTiles(GameComponents comp, ColorOfComponents color, Position pos) 
        {
            Components = comp;
            ColorOfComponents = color;
            PositionInBoard = pos;
        }
    }
}
