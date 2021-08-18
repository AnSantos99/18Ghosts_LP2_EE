using System;
using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.CursorVisible = false; 
            // Console.SetWindowSize(108, 50);

            //Menu menu = new Menu();
            //menu.DrawMenu();

            //GameBoard board = new GameBoard();
            //board.BoardStructure(); 
            BoardStructure[,] struc;
            ViewGameBoard boardDraw = new ViewGameBoard();
            GameBoard boardStructure = new GameBoard(struc); 
        }
    }
}