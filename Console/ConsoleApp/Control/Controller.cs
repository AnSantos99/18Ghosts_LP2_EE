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

        private BoardStructure structure;

        public Controller() 
        {
            menu = new Menu();
            board = new GameBoard();
        }

        public void GameLoop() 
        {
            //menu.DrawMenu();

            start = new ViewGameBoard(board);

            //Console.ReadKey();
            
        }
    }
}
