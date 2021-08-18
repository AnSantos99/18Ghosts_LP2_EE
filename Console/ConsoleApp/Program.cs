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
            //Controller controller = new Controller();

            ViewGameBoard start = new ViewGameBoard();
            start.DrawBoard();

            //GameBoard board = new GameBoard();
            //Controller controller = new Controller(board);

            //View gameView = new View(controller, board);
            //controller.Run(gameView);







        }
    }
}