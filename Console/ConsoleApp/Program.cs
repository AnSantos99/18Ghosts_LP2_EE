﻿

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.DrawMenu();

            Game start = new Game();
            start.Run();
        }

    }
}

