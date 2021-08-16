using System;

namespace ConsoleApp.Model
{
    class BoardStructure
    {
        /// <summary>
        /// Every board needs positions.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Every board needs its game/board features/objects
        /// </summary>
        public GameComponents GameComponent { get; set; }

        /// <summary>
        /// Every board piece needs to have a specific color
        /// </summary>
        public ColorOfComponents ColorOfComponents { get; set; }

        
        // Every Board needs ghosts
        public IGhost Ghost { get; }
        
        // Every Board needs to check if there are empty houses
    }
}
