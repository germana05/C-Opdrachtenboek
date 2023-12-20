using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Bewerking_variabelen
    {
        // opdracht 22
        static char Char1 = '9';
        static char Char2 = '1';

        // opdracht 23
        static int Int = 1;

        //opdracht 27
        static string String1 = "hello";
        static string String2 = "world";

        //opdracht 28
        static string String3;

        //opdracht 31
        static int Int1 = 6;
        static int Int2 = 18;
        static int Int3;

        // opdracht 35 & 36
        static string String4 = "5";
        static string String5;
        static int Int4 = 5;

        static void start()
        {
            // opdracht 24
            Int = Int32.Parse(Char1.ToString()) + Int32.Parse(Char2.ToString());
            // opdracht 25
            Console.WriteLine(Int);

            // zoals hoe het nu staat heb ik het antwoord wat ik verwachte.
            // eerst had ik gewoon Int = Char1 + Char2 gedaan waarbij ik als antwoord 106 kreeg in plaats van 10.

            // opdracht 29
            String3 = String1 + String2;

            // opdracht 30
            Console.WriteLine(String3);

            // opdracht 32
            Int3 = Int2 / Int1;

            // opdracht 33
            Console.WriteLine(Int3);

            //opdracht 34
            // eigenlijk is dat wel wat ik verwacht had ja. want ik doe 18 gedeeld door 6 en dat komt uit op 3.

            //opdracht 37
            String5 = String4 + Int4.ToString();

            //opdracht 39
            //dit is wel wat ik verwacht had. als je 2 strings plus elkaar doet mord het achter elkaar gezet waardoor je in dit geval 55 krijgt en niet 10.

            //opdracht 38
            Console.WriteLine(String5);

            Console.ReadKey();
        }
    }
}
