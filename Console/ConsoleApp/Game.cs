using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Game
    {




        public void StartGame() 
        {
            const int x_Dim = 5;
            const int y_Dim = 5;

            for (int i = 0; i < x_Dim; i++)
            {
                for (int j = 0; j < y_Dim; j++)
                {
                    Console.Write("-");
                }

                Console.WriteLine("  |");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        
    }
}
