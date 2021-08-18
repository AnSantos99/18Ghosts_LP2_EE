using ConsoleApp.View;
using ConsoleApp.Control;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; 
            Console.SetWindowSize(108, 50);


            Controller start = new Controller();
            start.GameLoop();

          

            //Controller controller = new Controller(board);

            //View gameView = new View(controller, board);
            //controller.Run(gameView);







        }
    }
}