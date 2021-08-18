using System;
using ConsoleApp.Model;

namespace ConsoleApp.View
{
    class ViewGameBoard
    {
        private GameBoard[,] board;

        public void DrawBoard() 
        {
            // Draw Top line of board
            for (int j = 0; j < 6; j++)
            {
                // Draw corners of each house 1 time
                for (int k = 0; k < 1; k++) 
                    Console.Write("═══╦");
                
                // Draw line till corner of each house
                Console.Write("═════");
            }
            // Draw right sight corner of board
            Console.Write("═╦");
            Console.WriteLine();

            /*---------------------------------------------------------------*/
            /*---------------------------------------------------------------*/

            // Draw inside of board 5 times excluding dungeon part
            for (int x = 0; x < board.GetLength(0); x++)
            {
                // Write Coordinate number from 0 - 4 on board
                Console.Write($" {x} ║");

                // Draw middle vertical lines to separate boxes
                for (int y = 0; y < 5; y++)
                {
                    Console.Write($"     ");

                    for (int i = 0; i < 1; i++)
                        Console.Write("   │");
                }

                // Draw dungeon right side boarder one time on every line
                for (int m = 0; m < 1; m++)
                    Console.Write("      ║");
               
                Console.WriteLine();

                // Draw vertical cordinate number lines
                for (int a = 0; a < 1; a++)
                    Console.Write("   ║");

                // Draw horizontal line from gameboard
                for (int y = 0; y < 5; y++)
                {
                    Console.Write("────────");

                    // Draw separator from every box on game board
                    for (int i = 0; i < 1; i++)
                        Console.Write("┼");
                }

                // Draw second vertical line for right dungeon border
                for (int j = 0; j < 1; j++)
                    Console.Write("      ║");

                Console.WriteLine();
            }

            // Draw last vertical line of coordinates number separate line
            Console.Write("   ║");

            // Draw horizontal coordinate number for each box on board
            for (int s = 0; s < 5; s++)
            {
                Console.Write($"   {s}   ");

                // Separate each number with a vertical line
                for (int i = 0; i < 1; i++)
                    Console.Write(" │");
            }

            // Draw last vertical line from right dungeon border
            Console.Write("      ║");
            Console.WriteLine();

            /*---------------------------------------------------------------*/
            /*---------------------------------------------------------------*/

            // Drawing bottom line of board
            for (int j = 0; j < 6; j++)
            {
                // Draw corner of each house 1 time 
                for (int k = 0; k < 1; k++)
                    Console.Write("═══╩");

                // Draw the rest of the line till next corner
                Console.Write("═════");
            }

            // Draw Last Corner of board
            Console.Write("═╩");
            Console.WriteLine();
        }
    }
}
