using ConsoleApp.View;
using ConsoleApp.Control;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            // fazewr Console.SetWindowSize(200, 50);
            //Console.CursorVisible = false; 
            //Console.SetWindowSize(108, 50);


            Controller start = new Controller();
            start.GameLoop();

          

            //Controller controller = new Controller(board);

            /* Create the Class Menu*/
=======
>>>>>>> 8c8e3a22a1b20caf374f1be8c0231de3a9dfa780
            Menu menu = new Menu();
            /* Calls the Method DrwMenu*/
            menu.DrawMenu();
            //View gameView = new View(controller, board);
            //controller.Run(gameView);
        }
    }
}
