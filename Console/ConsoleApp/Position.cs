namespace ConsoleApp
{
    class Position
    {
        public int XRow { get; set; }
        public int YCol { get; set; }

        public Position(int xRow, int yCol) 
        {
            XRow = xRow;
            YCol = yCol;
        }

        public Position() { }
    }
}
