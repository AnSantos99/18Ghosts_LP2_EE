using System;
using System.Collections.Generic;
using System.Text;

namespace RecursoLP2_PPT
{
    class GFight
    {
        private GameBoard[,] board;

        private IGhost currentGhost;
        private IGhost ghostColor;

        private bool ghostAtk = false;

        public static void SlectionEvent(GameBoard[,] board)
        {
            // Checks player turn
            // checks house player wants to attack
            //if all possible houses are empty ask for another action
            //if Ghost same color ask for another
            //if there is a Ghost with different color -> GhostFight();

        }

        public static void GhostFight(GameBoard[,] board)
        {
            // Rock paper Scissors base with 3 people?
            // Yellow beats Red; Red beats Blue; Blue beats Yellow;


            //Random random = new Random();
            string inputPiece1 = ghostColor;
            string inputPiece2 = ghostColor;

            //string inputPiece3 = "";

            bool winner = false;

            //Switch v for PlayerAtck.House & PlayerDef.House  (PlayerAtck = player atacking ; PlayerDef = player being attacked)

            int P1Score = 0;
            int P2Score = 0;

            while (!winner)
            {
                //int randomintP1 = random.Next(1, 4);
                //int randomintP2 = random.Next(1, 4);

                if (P1Score == P2Score && ghostAtk == true)
                {
                    switch (GameBoard[,] board)
                    { 
                        case 1:
                            inputPiece1 = "Red";
                            Console.WriteLine("P1 : R");
                            break;
                        case 2:
                            inputPiece1 = "Blue";
                            Console.WriteLine("P1 : B");
                            break;
                        case 3:
                            inputPiece1 = "Yellow";
                            Console.WriteLine("P1 : Y");
                            break;
                        default:
                            break;
                    }

                    switch (randomintP2)
                    {
                        case 1:
                            inputPiece2 = "Red";
                            Console.WriteLine("P2 : R");

                            if (inputPiece1 == "Yellow")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Blue")
                            {
                                P2Score++;
                            }

                            break;

                        case 2:
                            inputPiece2 = "Blue";
                            Console.WriteLine("P2 : B");

                            if (inputPiece1 == "Red")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Yellow")
                            {
                                P2Score++;
                            }

                            break;

                        case 3:
                            inputPiece2 = "Yellow";
                            Console.WriteLine("P2 : Y");

                            if (inputPiece1 == "Blue")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Red")
                            {
                                P2Score++;
                            }

                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}
