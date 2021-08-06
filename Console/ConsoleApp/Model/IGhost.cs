namespace ConsoleApp.Model
{
    interface IGhost
    {
        /// <summary>
        /// To know what type of ghost we are handling with
        /// </summary>
        public string ghostType { get; }

        /// <summary>
        /// Every ghost has a specific color. By creating a property we will
        /// be able to acess and find out what color that specific ghost is.
        /// </summary>
        public ColorOfComponent ghostColor { get; }

        ///////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Ghosts needs a position. This autoimplemented property
        /// </summary>
        public Position ghostPosition { get; set; }

        public void Attack() { }

        public void GoToDungeon() { }

        public void ReleaseFromDungeon() { }
    }
}
