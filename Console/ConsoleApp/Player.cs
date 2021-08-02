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

        Random rnd;


        public Player()
        {
            rnd = new Random();
            int x, y;

            x = rnd.Next(1, 25);
            y = rnd.Next(1, 25);

            playerPos = new Position(x, y);

            x = playerPos.XRow;
            y = playerPos.YCol;

            Console.SetCursorPosition(x, y);

            playerChar = "O";
            playerColor = ConsoleColor.Red;
        }


        public void DrawPlayerOnBoard() 
        {
            Console.ForegroundColor = playerColor;
            Console.SetCursorPosition(playerPos.XRow, playerPos.YCol);
            Console.Write(playerChar);
            Console.ResetColor();
        }

    }
}
