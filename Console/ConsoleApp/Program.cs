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

            //GameBoard gameBoard = new GameBoard();
            //Controller controller = new Controller();

            

            GameBoard board = new GameBoard();
            ViewGameBoard start = new ViewGameBoard(board);

            //Controller controller = new Controller(board);

            //View gameView = new View(controller, board);
            //controller.Run(gameView);







        }
    }
}