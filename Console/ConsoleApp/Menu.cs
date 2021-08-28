using System;

namespace ConsoleApp
{
    class Menu
    {
        //private string number;
        /* Declares a new game */
        private Game start;

        /// <summary>
        /// Menu construtor
        /// </summary>
        public Menu()
        {
            start = new Game();
        }

        /// <summary>
        /// Method to draw menu
        /// </summary>
        public void DrawMenu()
        {
            string title = @" 
                                                                   
                     @@@  @@@@@@     @@@@@@@  @@@  @@@  @@@@@@   @@@@@@ @@@@@@@ @@@@@@ 
                    @@@@ @@!  @@@   !@@       @@!  @@@ @@!  @@@ !@@       @!!  !@@     
                     !@!  !@!@!@    !@! @!@!@ @!@!@!@! @!@  !@!  !@@!!    @!!   !@@!!  
                     !!! !!:  !!!   :!!   !!: !!:  !!! !!:  !!!     !:!   !!:      !:! 
                     ::   :.:: :     :: :: :   :   : :  : :. :  ::.: :     :   ::.: :   ";

            /* Array with the choises names */
            string[] number = { "Play", "Rules", "Credits", "Quit" };
            /* Create MenuDisplay */
            MenuDisplay md = new MenuDisplay(title, number);
            /* Call method RunMenu */
            int Input = md.RunMenu();
            /* Clean console */
            Console.Clear();
            /* Switch input menu */
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

        /// <summary>
        /// Method to show rules
        /// </summary>
        private void Rules()
        {
            //Movimento WASD
            //release dungean R
             Console.WriteLine(@" 

    ╔ ========================================= Rules ======================================== ╗
       > There are 18 Ghost in total. Each player receives a pair of 9 ghosts, 
       that can be characterized by 3 colours (3 Blue, 3 Red and 3 Yellow) 
       in 2 types of ghosts. 
        
            In example: 1 Player receives one type of Ghosts that have a round 
           form and the other player, Ghosts with a round form (These 2 types of 
           ghosts only serve for the players to be able to distinguish their own ghosts.
        
       > The game start's by positioning the ghosts on the corresponding carpet 
      colour of the ghost itself (Red Ghost goes to red carpet, blue to blue 
      carpet and yellow to yellow carpet).
         After that the players can decide who starts first.

       > All players have the exact amount of 3 actions available:

            > A > Move a ghost to an empty chamber.
             The movement can be done only, orthogonally (Up, Down, Left Right). 
            You cannot move diagonally. 
             There are 4 mirrors. By moving into one, you can jump to another mirror 
            house available on the board.

            > B > How to fight enemy ghosts.
             Red beats Blue. 
             Blue beats Yellow.
             Yellow beats Red.

             Fighting occurs automatically. By trying to enter a chamber with an 
            opponent’s ghost in it. 
             You can also fight your own ghosts.

            > C > Release a ghost from the dungeon.
             The Dungeon is the place where eaten ghosts will end up 
            (They are not out of the game!).
             If you want to release your ghost from the dungeon, your opponent will 
            choose an empty chamber your Ghost will be positioned to. If there is 
            no empty chamber of the same colour as your ghosts’ colour, you will 
            not be able to release it until a chamber of its colour is free.
        
       > There are 3 portals on the board. Each board is characterized with 
       one colour (red, blue, yellow). In order to win the game, you must be 
       able to guide your ghosts to the right colour of the portal to set them free.
        But be cautious. Every time a ghost is sent to the dungeon, its 
       respective colour will change the portal with the same colour of the 
       ghost, 90 degrees in clockwise.
        
            In Example: 
            If a yellow ghost is sent to the dungeon, the yellow portal will turn 90 degrees.
            In order to escape, the portals opening must be facing the player's 
           ghost and the ghost will automatically be free (The ghost doesn’t have 
           to be in the same tile as the portal).
    ╚ ======================================================================================== ╝

                                   ║ Press any key to go back ║");
            Console.ReadLine();
            DrawMenu();
        }

        /// <summary>
        /// Method to show credits
        /// </summary>
        private void Credits()
        {
            Console.WriteLine(@" 

                                       ╔ ======== Credits ======== ╗
                                          Ana dos Santos 21900297 
                                          Joana Silva    21805651 
                                          Sara Gama      21705494 
                                       ╚ ========================= ╝

                                       ║ Press any key to go back ║");
            Console.ReadLine();
            DrawMenu();
        }
    }
}