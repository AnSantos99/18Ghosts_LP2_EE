namespace ConsoleApp.Model
{
    /// <summary>
    /// Class to get the position in row and col
    /// </summary>
    class Position
    {
        /// <summary>
        /// 
        /// </summary>
        public int XRow { get; set; }
        public int YCol { get; set; }

        /// <summary>
        /// Constructor to get the row and the col
        /// </summary>
        /// <param name="xRow"> Get/Set the wished position on Row </param>
        /// <param name="yCol"> Get/Set the wished position on Column </param>
        public Position(int xRow, int yCol) 
        {
            XRow = xRow;
            YCol = yCol;
        }

        /// <summary>
        /// Empty Constructor for initialization
        /// </summary>
        public Position() { }
    }
}
