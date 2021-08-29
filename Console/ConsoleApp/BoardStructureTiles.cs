using ConsoleApp.Model;

namespace ConsoleApp
{
    /// <summary>
    /// Class that contains the structure of the gameboard
    /// </summary>
    class BoardStructureTiles
    {
        /// <summary>
        /// Get and set the components of the board
        /// </summary>
        public GameComponents Components { get; set; }

        /// <summary>
        /// Get and set the colors of each component
        /// </summary>
        public ColorOfComponents ColorOfComponents { get; set; }

        /// <summary>
        /// Get access and set position for localization of each components
        /// </summary>
        public Position PositionInBoard { get; set; }

        /// <summary>
        /// Check if there are ghosts on the board
        /// </summary>
        public GhostsStructure GhostInBoard { get; set; }

        public DungeonStructure dungeon { get; set; }

        /// <summary>
        /// Constructor with diferent types of arguments to hep construct the
        /// actual game board
        /// </summary>
        /// <param name="comp"> Get Game components </param>
        /// <param name="color"> Get the colors of each component </param>
        /// <param name="pos"> Get and set the position for each component </param>
        public BoardStructureTiles(GameComponents comp, ColorOfComponents color, 
            Position pos)
        {
            Components = comp;
            ColorOfComponents = color;
            PositionInBoard = pos;
        }
    }
}
