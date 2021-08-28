using System;
using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp.Control
{
    class Controller
    {
        private Menu menu;

        private GameBoard board;

        private ViewGameBoard start;

        public Controller() 
        {
            menu = new Menu();
            board = new GameBoard();
        }

        public void GameLoop() 
        {
            /* Calls the Method DrwMenu*/
            menu.DrawMenu();

            start = new ViewGameBoard();

        }
    }
}
