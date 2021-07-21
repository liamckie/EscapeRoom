using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    public class Door
    {
        private string Code;

        public Door(string code)
        {
            Code = code;
        }

        public bool AttemptEscape()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You step up and try the door. It's locked and needs a code...");
            Console.Write("Please enter the code : ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string playerGuess = Console.ReadLine().ToLower().ToLower();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (playerGuess == Code)
            {
                Console.WriteLine("\nClick... the lock falls away. You escaped sucessfully!");
            }

            else
            {
                Console.WriteLine("\nNothing happened... the code you entered was wrong!");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            return playerGuess == Code;

        }
    }
}
