﻿using System;
using ConsoleApp.Model;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp.View
{
    /// <summary>
    /// Class used to draw the gameboard and specify where each component goes
    /// visually.
    /// </summary>
    class ViewGameBoard
    {
        private GameBoard board;

        private const string mirrow = "M";
        private string portal = "P";
        private const string carpet = "█";
        private const string curlyGhost = "AAAA";
        private const string roundGhost = "●";

        private Ghosts ghosts;
        private ViewGhosts ghostsView;

        //private ViewGhosts viewGhosts;

        public ViewGameBoard() 
        {
            board = new GameBoard();
            ghosts = new Ghosts();
            ghostsView = new ViewGhosts();
            //viewGhosts = new ViewGhosts(board);
            DrawBoard();
        }

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
                    Console.Write(" ║ \t    18 Ghosts\t   ");
                }

                if (index % 5 == 0)
                {
                    Console.WriteLine("    ║");

                    Console.WriteLine($" ║─────────────────────────────║");
                    Console.Write($"{incrementer}║");

                    //Console.Write("");
                    incrementer++;
                    
                }

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
            Console.Write("    ║");
            Console.WriteLine();

            CoordNumbersOnBoard();

            ButtonPartOfBoard();

        }

        /// <summary>
        /// Print last border of board on the top
        /// </summary>
        private void TopPartOfBoard()
        {
            // Draw right sight corner of board
            Console.Write(" ╦═════════════════════════════╦");
            Console.WriteLine();
        }

        /// <summary>
        /// Coordinates of button board
        /// </summary>
        private void CoordNumbersOnBoard() 
        {
            Console.WriteLine(" ║─────────────────────────────║");

            Console.Write($" ║   0    1    2    3    4     ║");

            Console.WriteLine();
        }

        /// <summary>
        /// Print last border of board on the button
        /// </summary>
        private void ButtonPartOfBoard() 
        {
            // Draw Last Corner of board
            Console.Write(" ╩═════════════════════════════╩");
            Console.WriteLine();
        }

        public void DrawGhost()
        {
            foreach (GhostsStructure item in ghosts.ghostsList)
            {
                if (item.GhostType == GhostType.CurlyGhost)
                {
                    Console.Write(curlyGhost);
                }

                if (item.GhostType == GhostType.RoundGhost)
                {
                    Console.Write(roundGhost);
                }

                if (item.GhostColor == ColorOfComponents.Blue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (item.GhostColor == ColorOfComponents.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (item.GhostColor == ColorOfComponents.Yellow)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.ResetColor();
            }
        }
    }
}
