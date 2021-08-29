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

        private BoardStructureTiles position;

        public Controller()
        {
            menu = new Menu();
            board = new GameBoard();
            position = new BoardStructureTiles();
        }

        public void GameLoop()
        {
            /* Calls the Method DrwMenu*/
            menu.DrawMenu();

            //
            start = new ViewGameBoard();
            int[] test = new int[2];
            int test2;

            // Ask coordenates
            Console.WriteLine("\n\tChoose an X and Y coordenate: ");
            // Receive and convert coordenates
            test2 = int.Parse(Console.ReadLine());
            Console.WriteLine(test2.ToString());

            // 
            foreach (BoardStructureTiles item in board.boardTiles)
            {
                test[0] = item.PositionInBoard.XRow;
                test[1] = item.PositionInBoard.YCol;
            }

            //  test2 = test[0] = position.PositionInBoard.XRow;
            //  test[1] = position.PositionInBoard.YCol;

            /*string h = GameBoard.GetElementAt(PositionInBoard.XRow, PositionInBoard.YCol);
            if (h == "U")
            {
                break;
            }*/

            /*for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(Player.[i, 0], Player.PositionInBoard.YCol[i, 1]);
                Console.Write(Player[i]);
            }/*

             for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(string.Format("{0} ", position.[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }*/
             
        }
    }
}
