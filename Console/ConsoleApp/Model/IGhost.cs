namespace ConsoleApp.Model
{
    interface IGhost
    {
        public int MaxNumberOfGhosts { set; }

        /// <summary>
        /// Every ghost has a specific color. By creating a property we will
        /// be able to acess and find out what color that specific ghost is.
        /// </summary>
        public ColorOfComponents GhostColor { get; set; }

        /// <summary>
        /// Ghosts needs a position. This autoimplemented property
        /// </summary>
        public Position GhostPosition { get; }

        public Player GetPlayer { get; }

        public GameBoard GameBoardPos { get; }
    }
}
