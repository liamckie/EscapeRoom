using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    public class RoomObj
    {
        private string Name;
        private string Description;

        public RoomObj(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"You inspect the {Name}");
            Console.WriteLine(Description);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n>>> Press any key to continue\n");
            Console.ReadKey(true);
        }
    }
}
