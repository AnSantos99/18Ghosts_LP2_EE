<<<<<<< HEAD
﻿using System;
using ConsoleApp.Model;
=======
﻿
>>>>>>> principle

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            GameBoard board = new GameBoard();
            board.BoardStructure();

            ConsoleColor carpetColor;

            string carpet = "█";

            carpetColor = ConsoleColor.Red;

            

            // Drawing Top
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k < 1; k++)
                {
                    Console.Write("═══╦");
                }
                Console.Write("═════");
            }
            Console.Write("═╦");
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////


            // Drawing inside of board
            for (int x = 0; x < 5; x++)
            {
                Console.Write($" {x} ║");

                for (int y = 0; y < 5; y++)
                {
                    if (x == 0 && y == 0 || x == 1 && y == 1)
                    {
                        Console.Write($"H");
                        continue;
                    }
                    Console.Write($"     ");
                    
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write("   │");
                    }  
                }

                for (int m = 0; m < 1; m++)
                {
                    Console.Write("      ║");
                }
                Console.WriteLine();
                

                for (int a = 0; a < 1; a++)
                {
                    Console.Write("   ║");
                }

                for (int y = 0; y < 5; y++)
                {
                    Console.Write("────────");

                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write("┼");
                    }
                }

                for (int j = 0; j < 1; j++)
                {
                    Console.Write("      ║");
                }
                Console.WriteLine();
            }

            Console.Write("   ║");

            for (int s = 0; s < 5; s++)
            {
                Console.Write($"   {s}   ");
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(" │");
                }
            }
            Console.Write("      ║");

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////
            // Drawing bottom part
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k < 1; k++)
                {
                    Console.Write("═══╩");
                }
                Console.Write("═════");
            }
            Console.Write("═╩");
            Console.WriteLine();  
=======
            // Console.CursorVisible = false; 
            // Console.SetWindowSize(108, 50);

            Menu menu = new Menu();
            menu.DrawMenu();
>>>>>>> principle
        }
    }
}