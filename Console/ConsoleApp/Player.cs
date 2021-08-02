using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// This class will be changed! Its only purpose now is to test other
    /// mechanics of the game.
    /// </summary>
    class Player
    {
        // O que os player necessitam:

        // Uma posição 
        public Position playerPos;

        // Um character para se destinguir to seu adversario
        private string playerChar;

        private ConsoleColor playerColor;


        public Player(string[,] board)
        {
            // Store row and col position in local variable of type int
            int x, y;

            // Create a randomizer for random selection of houses
            Random rnd = new Random();

            // Save board total number of elements in
            // row and col to local variables
            x = rnd.Next(board.GetLength(0));
            y = rnd.Next(board.GetLength(1));

            // instanciate the new position
            playerPos = new Position(x, y);

            // Store the choose position to position variable of type position
            x = playerPos.XRow;
            y = playerPos.YCol;

            // Set the cursor to the given random number in the array
            Console.SetCursorPosition(x, y);

            // Make a character (for visuals)
            playerChar = "O";

            // Choose a color for the character
            playerColor = ConsoleColor.Red;
        }

        //public Player()
        //{
        //    rnd = new Random();
        //    int x, y;

        //    x = rnd.Next(1, 25);
        //    y = rnd.Next(1, 25);

        //    playerPos = new Position(x, y);

        //    x = playerPos.XRow;
        //    y = playerPos.YCol;

        //    Console.SetCursorPosition(x, y);

        //    playerChar = "O";
        //    playerColor = ConsoleColor.Red;
        //}


        public void DrawPlayerOnBoard() 
        {
            Console.ForegroundColor = playerColor;
            Console.SetCursorPosition(playerPos.XRow, playerPos.YCol);
            Console.Write(playerChar);
            Console.ResetColor();
        }

    }
}
