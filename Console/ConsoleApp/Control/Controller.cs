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

        private ViewGhosts ghosts;

        public Controller() 
        {
            menu = new Menu();
            board = new GameBoard();
            ghosts = new ViewGhosts();
        }



        public void GameLoop() 
        {
            //menu.DrawMenu();
            start = new ViewGameBoard(board);
            ghosts.DrawGhostInBoardRandom();

            //Console.ReadKey();
            
        }
    }
}
