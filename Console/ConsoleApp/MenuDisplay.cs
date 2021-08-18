using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MenuDisplay
    {
        private int Index;
        private string[] Number;
        private string Arrow;

        public MenuDisplay(string arrow, string[] number)
        {
            Arrow = arrow;
            Number = number;
            Index = 0;
        }

        private void DisplayMenu()
        {
            Console.WriteLine(Arrow);
            for (int i = 0; i < Number.Length; i++)
            {
                string option = Number[i];
                string symbol;

                if (i == Index)
                {
                    symbol = "  >";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    symbol = " < ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"\t\t\t\t\t\t{symbol}{option}");
            }
            Console.ResetColor();
        }

        public int RunMenu()
        {
            ConsoleKey Press;
            do
            {
                Console.Clear();
                DisplayMenu();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Press = keyInfo.Key;

                if (Press == ConsoleKey.UpArrow)
                {
                    Index--;
                    if (Index == -1)
                    {
                        Index = Number.Length - 1;
                    }
                }
                else if (Press == ConsoleKey.DownArrow)
                {
                    Index++;
                    if (Index == Number.Length)
                    {
                        Index = 0;
                    }
                }
            } while (Press != ConsoleKey.Enter);
            return Index;
        }
    }
}