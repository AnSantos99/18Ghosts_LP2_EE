using System;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] b = new string[,] { };

            Board board = new Board(b);
            board.BoardStructure();

            //Game start = new Game();
            //start.Run();

            //Console.ReadKey();
        }
    }
}
