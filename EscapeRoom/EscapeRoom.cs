using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    public class EscapeRoom
    {
        private RoomObj Cane;
        private RoomObj Painting;
        private RoomObj DeskDrawer;
        private Door LockedDoor;
        private bool HasEscaped;

        public EscapeRoom()
        {
            Painting = new RoomObj("painting", "It's, oddly enough, a giant painting of mice. You think \"mice\" might be a clue.");
            Cane = new RoomObj("cane", "You realise it is actually a walking stick that a blind person might use.");
            DeskDrawer = new RoomObj("desk drawer", "It sticks slighty but you manage to jiggle it open. You find a post with the number \"three\" on it.");
            LockedDoor = new Door("three blind mice");
            HasEscaped = false;
        }

        public void StartRoom()
        {
            Console.Title = "Escape Room";
            Console.WriteLine(@$"+-------------+
| {Console.Title} |
+-------------+");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You wake up and groggily look around...");
            Console.ReadLine();
            Console.WriteLine("It looks like you are in some kind of Escape Room...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n>>> Press any key to continue\n"); 
            Console.ReadKey(true);

            while (!HasEscaped)
            {
                string choice = Nav();

                if (choice == "1")
                {
                    Painting.DisplayInfo();
                }

                else if (choice == "2")
                {
                    Cane.DisplayInfo();
                }

                else if (choice == "3")
                {
                    DeskDrawer.DisplayInfo();
                }

                else if (choice == "4")
                {
                    bool wasSuccessful = LockedDoor.AttemptEscape();
                    HasEscaped = wasSuccessful;
                }

                else
                {
                    Console.WriteLine("That's not a valid option. Please choose an number from 1-4!");
                    Console.ReadLine();
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        private string Nav()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"+-- MENU -----------------------+
 Where would you like to look?
  1. a painting
  2. a cane
  3. a desk drawer
  4. a door");
            Console.Write("\n >>> ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string navChoice = Console.ReadLine().Trim();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+-------------------------------+\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

            return navChoice;
        }
    }
}
