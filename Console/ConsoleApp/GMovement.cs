using System;
using System.Collections.Generic;
using System.Text;

namespace RecursoLP2_PPT
{
    class GMovement
    {
        public static void reproductionEvent(char[,] board, int bnumY, int bnumX, int colrR, int colrG, int colrB)
        {
            int numChecked = 2;
            //run through board X and check if piece
            bool chosenPiece;
            Random random = new Random();

            //runs the board and does a random in each house to see if its R, G, B or Blank piece
            for (int row = 0; row < bnumX; row++)
            {
                chosenPiece = true;

                for (int col = 0; col < bnumY; col++)
                {
                    chosenPiece = true;

                    while (chosenPiece)
                    {
                        int randomNum = random.Next(0, 2);

                        if (board[row, col] == 'R' || board[row, col] == 'G' || board[row, col] == 'B')
                        {
                            if (randomNum == 0)
                            { 
                                continue;
                            }

                            if (randomNum == 1)
                            {
                                //check x, y +1 && x, y-1
                                continue;
                            }
                        }

                        if (board[row, col] == ' ')
                        {
                            continue;
                        }
                    }
                }
                //random select adjacent house
                //             |
                //check if its empty or piece
                //if both empty or full --> continue
                //if one empty = put same type of piece there --> continue

                //go down on the Y

                //repeat
            }
        }
    }
}
