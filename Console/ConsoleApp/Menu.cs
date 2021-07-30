using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Menu
    {

        private string number;
        private Game start;

        public Menu()
        {
            start = new Game();
            
        }


        public void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t  Welcome to PacMan\n\n");
            Console.WriteLine("\t\t\t\t Menu\n");
            Console.WriteLine("\t\t\t    1 Start Game ");
            Console.WriteLine("\t\t\t    2 Rules ");
            Console.WriteLine("\t\t\t    3 Credits ");
            Console.WriteLine("\t\t\t    4 Quit ");
            number = Console.ReadLine();
            Input(number);
        }

        private void Input(string number)
        {
            Console.Clear();

            switch (number)
            {
                case "1":
                    start.Run();
                    break;
                case "2":
                    Rules();
                    break;
                case "3":
                    Credits();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ERRO");
                    break;
            }
        }

        private void Rules()
        {
            Console.WriteLine("\n\n\t\t\t\t Rules\n");
            Console.WriteLine("\tYou are Pac Man and you're objective is to eat all the balls ");
            Console.WriteLine(" without being eating by the ghosts");
            Console.ReadKey();
            DrawMenu();
        }

        private void Credits()
        {
            Console.WriteLine("\n\n\t\t\t\t Credits\n");
            Console.WriteLine("\t\t\tAna dos Santos 21900297");
            Console.WriteLine("\t\t\tJoana Silva    21805651");
            Console.WriteLine("\t\t\tSara Gama      21705494");
            Console.ReadKey();
            DrawMenu();
        }
    }
}
