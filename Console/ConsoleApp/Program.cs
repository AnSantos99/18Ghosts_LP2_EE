using System;
using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.CursorVisible = false; 
            //Console.SetWindowSize(108, 50);

            //Menu menu = new Menu();
            //menu.DrawMenu();

            GameBoard gameBoard = new GameBoard();
            gameBoard.BoardStructure();



            
           
        }
    }
}