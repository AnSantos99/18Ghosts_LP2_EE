using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// This class serves as the main motor of the game where all methods in
    /// terms of rules, menus, credits and the game itself will be called
    /// for the game to run.
    /// </summary>
    class Game
    {

        public GameBoard board; 

        public void Run() 
        {
            board = new GameBoard();

            board.DrawBoard();
        }

        public void StartGame() 
        {
            const int x_Dim = 5;
            const int y_Dim = 5;

            for (int i = 0; i < x_Dim; i++)
            {
                for (int j = 0; j < y_Dim; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine("  |");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        
    }
}
