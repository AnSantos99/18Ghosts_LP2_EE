﻿namespace ConsoleApp.Model
{
    class DungeonStructure
    {
        public bool isEmpty;

        /// <summary>
        /// To check if there is any ghost in it
        /// </summary>
        public bool HasGhost { get; set; }

        public DungeonStructure() 
        {
            isEmpty = true;
        }
    }
}
