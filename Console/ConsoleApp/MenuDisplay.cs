using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MenuDisplay
    {   /* Index for the Menu input*/
        private int Index;
        /* String array for the Menu options*/
        private string[] Number;
        /* Variable for the */
        private string Title;

        /// <summary>
        /// MenuDisplay constructor
        /// </summary> 
        /// <param name="number">Menu options</param>
        public MenuDisplay(string title, string[] number)
        {
            Title = title;
            Number = number;
            Index = 0;
        }

        /// <summary>
        /// Method for the input interaction
        /// </summary>
        private void DisplayMenu()
        {
            /* Draws the title name */
            Console.WriteLine(Title);
            /* For to generate the numbers for the menu input */
            for (int i = 0; i < Number.Length; i++)
            {
                /* Variable for the array of menu choises */
            string option = Number[i];
                /* Variable for the symbol draw */
                string symbol;
                /* If to create the index and symbol of the input menu */
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

        /// <summary>
        ///     
        /// </summary>
        /// <returns></returns>
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