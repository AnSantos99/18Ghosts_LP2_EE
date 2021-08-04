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
        private GameBoard boardSettings;

        private Player currentPlayer;

        bool winLoseState;

        public void Run() 
        {
            string[,] boardStructure =
            {
                {"╔", "═", "═","╦", "═","═","╦","═", "═","╦","═", "═","╦","═", "═", "╦════╗"}, // 0
                {"║", " ", " ","│", " "," ","│"," ", " ","│"," ", " ","│"," ", " ", "║    ║"}, // 1
                {"╠", "─", "─","┼", "─","─","┼","─", "─","┼","─", "─","┼","─", "─", "║    ║"}, // 2
                {"║", " ", " ","│", "▒"," ","│"," ", " ","│"," ", "▒","│"," ", " ", "║    ║"}, // 3
                {"╠", "─", "─","┼", "─","─","┼","─", "─","┼","─", "─","┼","─", "─", "║    ║"}, // 4
                {"║", " ", " ","│", " "," ","│"," ", " ","│"," ", " ","│"," ", " ", "║    ║"}, // 5
                {"╠", "─", "─","┼", "─","─","┼","─", "─","┼","─", "─","┼","─", "─", "║    ║"}, // 6
                {"║", " ", " ","│", "▒"," ","│"," ", " ","│"," ", "▒","│"," ", " ", "║    ║"}, // 7
                {"╠", "─", "─","┼", "─","─","┼","─", "─","┼","─", "─","┼","─", "─", "║    ║"}, // 8
                {"║", " ", " ","│", " "," ","│"," ", " ","│"," ", " ","│"," ", " ", "║    ║"}, // 9
                {"╚", "═", "═","╩", "═","═","╩","═", "═","╩","═", "═","╩","═", "═", "╩════╝"} //10
            };

            boardSettings = new GameBoard(boardStructure);
            boardSettings.DrawGameBoard();

            currentPlayer = new Player(boardStructure);
            currentPlayer.DrawPlayerOnBoard();
        }

        


        public void gameLoop() 
        {
            while (!winLoseState) 
            {
                // Draw everything

                // Check input 
            }

        }
        
    }
}
