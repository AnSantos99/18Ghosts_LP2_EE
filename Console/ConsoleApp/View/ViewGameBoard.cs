using System;
using ConsoleApp.Model;

namespace ConsoleApp.View
{
    /// <summary>
    /// Class used to draw the game visually on console with its components and
    /// ghosts.
    /// </summary>
    class ViewGameBoard
    {
        /// <summary>
        /// Variable of type game to get access to the board logic of the board
        /// and its structure.
        /// </summary>
        private GameBoard board;

        // Private strings to identify the components of the game.
        // Variables with keyword const wont be modified (visually)
        // throughout the program.
        private const string mirrow = "M";
        private string portal = "P";
        private const string carpet = "█";
        private const string curlyGhost = "§";
        private const string roundGhost = "¤";

        /// <summary>
        /// Class constructor initializing and drawing the board by its call.
        /// </summary>
        public ViewGameBoard() 
        {
            board = new GameBoard();
            board.BoardStructure();
            DrawBoard();

        }

        /// <summary>
        /// Private method that draws the gameboard and its specific components
        /// according to the structure logic of class BoardStructureTiles and
        /// GhostStructure.
        /// This method goes through an existing list (boardTiles) of type
        /// Boardstructure where there is specified where each object belongs
        /// to depending on the position of the bidimensional array.
        /// 
        /// </summary>
        private void DrawBoard()
        {
            TopPartOfBoard();

            int index = 0;
            int incrementer = 0;

            // Go through the 
            foreach (BoardStructureTiles item in board.boardTiles)
            {
                if (index == 0)
                {
                    CoordNumbersOnBoard();
                }

                if (index % 5 == 0)
                {

                    Console.WriteLine("    ║          ║");

                    Console.WriteLine(
                        "║───║─────────────────────────────║          ║");
                    Console.Write($"║ {incrementer} ║");
                
                    //Console.Write("");
                    incrementer++;  
                }

                if (item.GhostInBoard != null)
                {
                    if (item.GhostInBoard.GhostColor == ColorOfComponents.Blue)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        string print;

                        print = item.GhostInBoard.GhostType == 
                            GhostType.CurlyGhost ? 
                            $"   {curlyGhost} " : $"   {roundGhost} ";
                        Console.Write($"{print}");
                    }

                    if (item.GhostInBoard.GhostColor == ColorOfComponents.Yellow)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string print;

                        print = item.GhostInBoard.GhostType == 
                            GhostType.CurlyGhost ? 
                            $"   {curlyGhost} " : $"   {roundGhost} ";
                        Console.Write($"{print}");

                    }

                    if (item.GhostInBoard.GhostColor == ColorOfComponents.Red)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        string print;

                        print = item.GhostInBoard.GhostType == 
                            GhostType.CurlyGhost ? 
                            $"   {curlyGhost} " : $"   {roundGhost} ";
                        Console.Write($"{print}");
                    }

                    Console.ResetColor();
                    index++;
                }

                else if(item.GhostInBoard == null)
                {
                    if (item.ColorOfComponents == ColorOfComponents.Blue)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }

                    if (item.ColorOfComponents == ColorOfComponents.Yellow)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }

                    if (item.ColorOfComponents == ColorOfComponents.Red)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }

                    if (item.Components == GameComponents.Carpet)
                    {
                        Console.Write($"   {carpet} ");
                    }

                    if (item.Components == GameComponents.Mirrow)
                    {
                        Console.Write($"   {mirrow} ");
                    }

                    if (item.Components == GameComponents.Portal)
                    {
                        Console.Write($"   {portal} ");
                    }
                    Console.ResetColor();

                    index++;
                }
            }  
            Console.Write("    ║          ║");
            Console.WriteLine();

            ButtonPartOfBoard();
        }

        /// <summary>
        /// Print last border of board on the top
        /// </summary>
        private void TopPartOfBoard()
        {
            // Draw right sight corner of board
            Console.Write("╔═══╦═════════════════════════════╦══════════╗");
            Console.WriteLine();
        }

        /// <summary>
        /// Coordinates of button board
        /// </summary>
        private void CoordNumbersOnBoard() 
        {
            Console.Write($"║   ║   0    1    2    3    4 ");
        }

        /// <summary>
        /// Print last border of board on the button
        /// </summary>
        private void ButtonPartOfBoard() 
        {
            Console.WriteLine("║───║═════════════════════════════║          ║");
            Console.WriteLine("║   ║           Castle            ║  Dungeon ║");

            // Draw Last Corner of board
            Console.Write("╚═══╩═════════════════════════════╩══════════╝");
            Console.WriteLine();
        }

        
        
    }
}
