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
        GameBoard boardSettings;

        private string[,] boardStructure =
        {
            { "╔", "══", "╦═", "═","╦═", "═","╦═", "═","╦═", "═", "╦════╗" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╠", "──", "┼", "──","┼", "──","┼", "──","┼", "──", "║    ║" },
            { "║", "  ", "│", "  ","│", "  ","│", "  ","│", "  ", "║    ║" },
            { "╚", "══", "╩═", "═","╩═", "═","╩", "══","╩═", "═", "╩════╝" }
        };

        

        public void Run() 
        {
            boardSettings = new GameBoard(boardStructure);
            boardSettings.DrawGameBoard();
            Console.WriteLine(boardSettings.ValidPositionCheck(0,0));
            Console.WriteLine(boardSettings.ValidPositionCheck(1,1));
        }
        
    }
}
