using System;
using System.Collections.Generic;
using System.Text;

namespace RecursoLP2_PPT
{
    class GFight
    {
        public static void SlectionEvent(char[,] board, int bnumY, int bnumX)
        {
            Random random = new Random();
            //run through board X and check if piece
            bool chekedPiece;

            //runs the board and does a random in each house to see if its R, G, B or Blank piece
            for (int row = 0; row < bnumX; row++)
            {
                chekedPiece = true;

                for (int col = 0; col < bnumY; col++)
                {
                    chekedPiece = true;

                    while (chekedPiece)
                    {
                        int randomNum = random.Next(0, 4);

                        if (board[row, col] == 'R' || board[row, col] == 'G' || board[row, col] == 'B')
                        {
                            if (randomNum == 0)
                            {
                                //check x +1, y && x -1, y
                                continue;
                            }

                            if (randomNum == 1)
                            {
                                //check x, y +1 && x, y-1
                                continue;
                            }

                            if (randomNum == 2)
                            {
                                //check x +1, y && x, y+1
                                continue;
                            }

                            if (randomNum == 3)
                            {
                                //check x -1, y && x, y-1
                                continue;
                            }
                        }

                        if (board[row, col] == ' ')
                        {
                            continue;
                        }
                    }
                }
                //random select 2 houses
                //             |
                //check if its empty or piece
                //if both empty, the same type or only one is empty/full --> pass
                //if both full = do the GhostFight() = loser turns into empty piece --> continue

                //go down on the Y

                //repeat
            }
        }

        public static void GhostFight()
        {
            Random random = new Random();
            string inputPiece1 = "";
            string inputPiece2 = "";
            string inputPiece3 = "";

            bool winner = false;


            int P1Score = 0;
            int P2Score = 0;
            int P3Score = 0;

            while (!winner)
            {
                int randomintP1 = random.Next(1, 4);
                int randomintP2 = random.Next(1, 4);
                int randomintP3 = random.Next(1, 4);

                if (P1Score == P2Score)
                {
                    switch (randomintP1)
                    {
                        case 1:
                            inputPiece1 = "Rock";
                            Console.WriteLine("P1 : R");
                            break;
                        case 2:
                            inputPiece1 = "Paper";
                            Console.WriteLine("P1 : P");
                            break;
                        case 3:
                            inputPiece1 = "Scissors";
                            Console.WriteLine("P1 : S");
                            break;
                        default:
                            break;
                    }

                    switch (randomintP2)
                    {
                        case 1:
                            inputPiece2 = "Rock";
                            Console.WriteLine("P2 : R");

                            if (inputPiece1 == "Paper")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Scissors")
                            {
                                P2Score++;
                            }

                            break;

                        case 2:
                            inputPiece2 = "Paper";
                            Console.WriteLine("P2 : P");

                            if (inputPiece1 == "Scissors")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Rock")
                            {
                                P2Score++;
                            }

                            break;

                        case 3:
                            inputPiece2 = "Scissors";
                            Console.WriteLine("P2 : S");

                            if (inputPiece1 == "Rock")
                            {
                                P1Score++;
                            }

                            else if (inputPiece1 == "Paper")
                            {
                                P2Score++;
                            }

                            break;

                        default:
                            break;
                    }

                    if (P1Score != P2Score)
                    {
                        Console.WriteLine("\nBINGO\n");//<---Just for testing purpose
                        winner = true;
                    }

                    if (P1Score == P2Score)//Just for testing purpose
                    {
                        Console.WriteLine("\nRETRY\n");
                        winner = false;
                    }
                }
            }
            Console.WriteLine("Score:\nP1:" + P1Score + "\nP2:" + P2Score + "\nFin");
        }
    }
}
