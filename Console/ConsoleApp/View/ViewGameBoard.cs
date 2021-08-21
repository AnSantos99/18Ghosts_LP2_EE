using System;
using ConsoleApp.Model;

namespace ConsoleApp.View
{
    class ViewGameBoard
    {
        
        private GameBoard board;

        private const string mirrow = "M";
        private string portal = "P";
        private const string carpet = "P";


        public ViewGameBoard(GameBoard board) 
        {
            this.board = board;
            DrawBoard();
        }

        private void DrawBoard() 
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
            for (int x = 0; x < board.gameBoard.GetLength(0); x++)
            {
                // Write Coordinate number from 0 - 4 on board
                Console.Write($" {x} ║");

                // Draw middle vertical lines to separate boxes
                for (int y = 0; y < board.gameBoard.GetLength(1); y++)
                {

                    if (x == 1 && y == 1 || x == 3 && y == 1 ||
                        x == 1 && y == 3 || x == 3 && y == 3)
                    {
                        Console.Write($"   {mirrow} ");
                    }

                    else if (x == 0 && y == 2 || x == 4 && y == 2 || 
                        x == 2 && y == 4)
                    {
                        Console.Write($"   {portal} ");
                    }

                    else if (x == 0 && y == 1 || x == 0 && y == 4 || 
                        x == 2 && y == 0 || x == 2 && y == 2 || 
                        x == 3 && y == 4 || x == 4 && y == 1)
                    {
                        Console.Write($"   r ");
                    }

                    else if (x == 0 && y == 0 || x == 0 && y == 3 ||
                        x == 2 && y == 1 || x == 2 && y == 3 ||
                        x == 3 && y == 0 || x == 4 && y == 3)
                    {
                        Console.Write($"   B ");
                    }

                    else if(x == 1 && y == 0 || x == 1 && y == 2 ||
                        x == 1 && y == 4 || x == 3 && y == 2 ||
                        x == 4 && y == 0 || x == 4 && y == 4)
                    {
                        Console.Write($"   Y ");
                    }

                    //else
                    //{
                    //    Console.Write($"     ");
                    //}

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
                for (int xLine = 0; xLine < board.gameBoard.GetLength(0); 
                    xLine++)
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
            for (int x = 0; x < board.gameBoard.GetLength(0); x++)
            {
                Console.Write($"    {x}  ");

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
