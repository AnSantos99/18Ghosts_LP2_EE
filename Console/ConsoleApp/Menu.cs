using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Menu
    { 
        // •••Encoding ascii = Encoding.ASCII; / row 122
        private string number;
        private Game start;

        public Menu()
        {
            start = new Game();
            
        }

        //╔ ===== Jobs/Help ===== ╗
        public void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t      Welcome to 18 Ghosts\n\n");
            Console.WriteLine("\t\t\t\t╔ ==== Menu ==== ╗\n");
            Console.WriteLine("\t\t\t\t   1 Start Game ");
            Console.WriteLine("\t\t\t\t   2 Rules ");
            Console.WriteLine("\t\t\t\t   3 Credits ");
            Console.WriteLine("\t\t\t\t   4 Quit ");
            Console.WriteLine("\t\t\t\t╚ ============== ╝");
            //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            //Console.Read();
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
                    Console.WriteLine("If u don't want to be eaten... RUUUN! NOW!!!!");
                    break;
            }
        }

        private void Rules()
        {
            Console.WriteLine("\n\n\n\n\t╔ ===================== Rules ===================== ╗\n");
            Console.WriteLine("\t  > The players take turns and both of them have");
            Console.WriteLine("\t  9 blue, red and yellow ghosts.");
            Console.WriteLine("\t    In you're turn you can make 3 choises:\n");
            Console.WriteLine("\t  A > Move a ghost to an empty chamber.");
            Console.WriteLine("\t    The movement can be done vertically or orthogonally.");
            Console.WriteLine("\t    There's 4 mirros where if you go to a mirror house you can jump to another mirror house.\n");
            Console.WriteLine("\t  B > Fight enemy's ghost.");
            Console.WriteLine("\t    Red beat Blue;\n\t    Blue beat Yellow;\n\t    Yellow beat Red.\n");
            Console.WriteLine("\t  C > Release a ghost from the dungeon.");
            Console.WriteLine("\t    Dungeon it's the place where the eaten ghost goes");
            Console.WriteLine("\t  they can come up to the grid if there's space for it.\n");
            Console.WriteLine("\t  > The game have 3 portals one for each ghost ");
            Console.WriteLine("\t   color to exit the game.");
            Console.WriteLine("\t  > Wins the one with 1 or more ghost out of the grid.");
            Console.WriteLine("\t╚ ================================================= ╝");
            Console.ReadKey();
            DrawMenu();
        }

        private void Credits()
        {
            Console.WriteLine("\n\n\n\n\t\t\t╔ ======== Credits ======== ╗\n");
            Console.WriteLine("\t\t\t   Ana dos Santos 21900297");
            Console.WriteLine("\t\t\t   Joana Silva    21805651");
            Console.WriteLine("\t\t\t   Sara Gama      21705494");
            Console.WriteLine("\t\t\t╚ ========================= ╝");
            Console.ReadKey();
            DrawMenu();
        }
    }
}
