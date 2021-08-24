using ConsoleApp;
using ConsoleApp.Model;
using System;

namespace RecursoLP2_PPT
{
    class GFight
    {
        private GameBoard board;

        private IGhost currentGhost;
        private IGhost ghostColor;
        private bool ghostAtk;
        private ColorOfComponents winCondition;
        private IGhost p1Score;
        private IGhost p2Score;
        private Position[,] pos;
        ConsoleApp.Model.Player[,] gPos;

        public GFight()
        {
            ghostAtk = false;
            board = new GameBoard();
        }

        public void GhostFight(GameBoard[,] board)
        {

            // Yellow beats Red; Red beats Blue; Blue beats Yellow;


            //Random random = new Random();
            //string inputPiece1 = currentGhost;
            //string inputPiece2 = ghostColor;

            //string inputPiece3 = "";

            bool winner = false;

            //Switch v for PlayerAtck.House & PlayerDef.House  (PlayerAtck = player atacking ; PlayerDef = player being attacked)
           

            ConsoleApp.Model.Player currentPos = gPos[board.GetLength(0), board.GetLength(1)];

            while (!winner)
            {
                //int randomintP1 = random.Next(1, 4);
                //int randomintP2 = random.Next(1, 4);

                if (ghostAtk == true)
                {
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            if (currentPos. == p2Score.GameBoardPos.gameBoard.GetLength())
                            {
                                if (p1Score.GhostColor == ColorOfComponents.Red && p2Score.GhostColor == ColorOfComponents.Red)
                                {
                                    //score == 0; nothing happens
                                    //Put warning text :o
                                }
                            }
                        }
                    }
                    

                    //switch (winCondition)
                    //{
                    //    case :
                    //        inputPiece1 = "Red";
                    //        //Console.WriteLine("P1 : R");
                    //        break;
                    //    case 2:
                    //        inputPiece1 = "Blue";
                    //        //Console.WriteLine("P1 : B");
                    //        break;
                    //    case 3:
                    //        inputPiece1 = "Yellow";
                    //        //Console.WriteLine("P1 : Y");
                    //        break;
                    //    default:
                    //        break;
                    //}

                    //switch (randomintP2)
                    //{
                    //    case 1:
                    //        inputPiece2 = "Red";
                    //        Console.WriteLine("P2 : R");

                    //        if (inputPiece1 == "Yellow")
                    //        {
                    //            P1Score++;
                    //        }

                    //        else if (inputPiece1 == "Blue")
                    //        {
                    //            P2Score++;
                    //        }

                    //        break;

                    //    case 2:
                    //        inputPiece2 = "Blue";
                    //        Console.WriteLine("P2 : B");

                    //        if (inputPiece1 == "Red")
                    //        {
                    //            P1Score++;
                    //        }

                    //        else if (inputPiece1 == "Yellow")
                    //        {
                    //            P2Score++;
                    //        }

                    //        break;

                    //    case 3:
                    //        inputPiece2 = "Yellow";
                    //        Console.WriteLine("P2 : Y");

                    //        if (inputPiece1 == "Blue")
                    //        {
                    //            P1Score++;
                    //        }

                    //        else if (inputPiece1 == "Red")
                    //        {
                    //            P2Score++;
                    //        }

                    //        break;

                    //    default:
                    //        break;
                    //}
                }
            }
        }
    }
}
