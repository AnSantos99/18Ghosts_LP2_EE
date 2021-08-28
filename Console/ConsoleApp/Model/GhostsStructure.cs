namespace ConsoleApp.Model
{
    class GhostsStructure
    {
        /// <summary>
        /// Ghosts have a specific type to be able to distinguish them from
        /// another
        /// </summary>
        public GhostType GhostType { get; set; }

        /// <summary>
        /// Every ghost has a specific color. By creating a property we will
        /// be able to acess and find out what color that specific ghost is.
        /// </summary>
        public ColorOfComponents GhostColor { get; set; }

        /// <summary>
        /// Ghosts needs a position. This autoimplemented property
        /// </summary>
        public Position GhostPosition { get; set; }

        public GameComponents GameComponents { get; }

        /// <summary>
        /// Constructor to be able to create any type of a ghost
        /// </summary>
        /// <param name="ghostType"> Get the type of ghost </param>
        /// <param name="ghostColor"> Get the color </param>
        /// <param name="ghostPosition"> Get the position </param>
        public GhostsStructure(GhostType ghostType, ColorOfComponents ghostColor,
            Position ghostPosition, GameComponents gameComponents)
        {
            GhostType = ghostType;
            GhostColor = ghostColor;
            GhostPosition = ghostPosition;
            GameComponents = gameComponents;
        }

        public GhostsStructure() { }
    }
}
