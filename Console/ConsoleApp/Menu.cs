using System;

namespace ConsoleApp
{
    class Menu
    {
        // •••Encoding ascii = Encoding.ASCII; / row 122
        private string number;
        //private Game start;

        //public Menu()
        //{
        //    start = new Game();
        //}

        public void DrawMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string arrow = @" 
                                                                   
                     @@@  @@@@@@     @@@@@@@  @@@  @@@  @@@@@@   @@@@@@ @@@@@@@ @@@@@@ 
                    @@@@ @@!  @@@   !@@       @@!  @@@ @@!  @@@ !@@       @!!  !@@     
                     !@!  !@!@!@    !@! @!@!@ @!@!@!@! @!@  !@!  !@@!!    @!!   !@@!!  
                     !!! !!:  !!!   :!!   !!: !!:  !!! !!:  !!!     !:!   !!:      !:! 
                     ::   :.:: :     :: :: :   :   : :  : :. :  ::.: :     :   ::.: :  
            ";

            string[] number = { "Play", "Rules", "Credits", "Quit" };
            MenuDisplay md = new MenuDisplay(arrow, number);
            int Input = md.RunMenu();
            Console.Clear();

            switch (Input)
            {
                case 0:
                    //start.Run();
                    break;
                case 1:
                    Rules();
                    break;
                case 2:
                    Credits();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nIf u don't want to be eaten... RUUUN! NOW!!!!");
                    break;
            }
        }

       private void Rules()
        {
            //Movimento WASD
            //release dungean R
            Console.WriteLine("\n\n\t╔ ===================== Rules ====================== ╗\n");
            Console.WriteLine("\t  > The players take turns and both of them have");
            Console.WriteLine("\t  9 blue, red and yellow ghosts.");
            Console.WriteLine("\t    In you're turn you can make 3 choises:\n");
            Console.WriteLine("\t  A > Move a ghost to an empty chamber.");
            Console.WriteLine("\t    The movement can be done vertically or orthogonally.");
            Console.WriteLine("\t    There's 4 mirros where if you go to a mirror house");
            Console.WriteLine("\t  you can jump to another mirror house.\n");
            Console.WriteLine("\t  B > Fight enemy's ghost.");
            Console.WriteLine("\t    Red beat Blue;\n\t    Blue beat Yellow;\n\t    Yellow beat Red.\n");
            Console.WriteLine("\t  C > Release a ghost from the dungeon.");
            Console.WriteLine("\t    Dungeon it's the place where the ghost goes");
            Console.WriteLine("\t  when you lose a fight, they can come to the grid");
            Console.WriteLine("\t  again if there's space for it.\n");
            Console.WriteLine("\t  > The game have 3 portals one for each ghost");
            Console.WriteLine("\t  color to exit the game.");
            Console.WriteLine("\t  > Wins the one with 1 or more ghost out of the grid.");
            Console.WriteLine("\t╚ =================================================== ╝\n");
            Console.WriteLine("\n\t╔ =============== Keys ============== ╗\n");
            Console.WriteLine("\t   To move Ghost press W, A, S and D");
            Console.WriteLine("\t   To realeas Ghost press R");
            Console.WriteLine("\t╚ =================================== ╝\n");
            Console.WriteLine("\t     ║ Press any key to go back ║");
            Console.ReadKey();
            DrawMenu();
        }

        private void Credits()
        {
            Console.WriteLine("\n\n\t\t\t╔ ======== Credits ======== ╗\n");
            Console.WriteLine("\t\t\t   Ana dos Santos 21900297");
            Console.WriteLine("\t\t\t   Joana Silva    21805651");
            Console.WriteLine("\t\t\t   Sara Gama      21705494");
            Console.WriteLine("\t\t\t╚ ========================= ╝\n");
            Console.WriteLine("\t\t\t║ Press any key to go back ║");
            Console.ReadKey();
            DrawMenu();
        }
    }
}