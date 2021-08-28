using ConsoleApp.Model;

namespace ConsoleApp
{
    class BoardStructureTiles
    {
        public GameComponents Components { get; set; }

        public ColorOfComponents ColorOfComponents { get; set; }

        public Position PositionInBoard { get; set; }

        public GhostType GhostInBoard { get; }

        public BoardStructureTiles(GameComponents comp, ColorOfComponents color, 
            Position pos, GhostType ghosts)
        {
            Components = comp;
            ColorOfComponents = color;
            PositionInBoard = pos;
            GhostInBoard = ghosts;
        }

        public BoardStructureTiles() { }
    }
}
