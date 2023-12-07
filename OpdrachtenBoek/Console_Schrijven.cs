using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Console_Schrijven
    {
        static void Start()
        {
            //een Console.WriteLine gebruikt elke keer dat je hem gebruikt zijn eigen lijn.
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            // een Console.Write gaat verder op de zelfde lijn als de vorige Console.Write.
            Console.Write("Hello world");
            Console.Write("Hello world");
            Console.Write("Hello world");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello world");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello world");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("Hello");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("world");
            Console.ReadKey();

            Opdracht7(ConsoleColor.Magenta, ConsoleColor.Blue, "Hello world");
            Console.ReadKey();
        }

        static void Opdracht7(ConsoleColor color1, ConsoleColor color2, string text)
        {
            Console.ForegroundColor = color1;
            Console.BackgroundColor = color2;

            Console.WriteLine(text);

            Console.ResetColor();
        }
    }
}
