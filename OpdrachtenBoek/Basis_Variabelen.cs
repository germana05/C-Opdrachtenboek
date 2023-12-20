using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Basis_Variabelen
    {
        //Opdracht 16 en 17
        static int Int = 5;
        static string String = "Hello World";
        static char Char = '!';
        static float Float = 5.55f;
        static bool Bool = true;

        static void Start()
        {
            //Opdracht 18
            String = Console.ReadLine();
            Bool = false;

            Console.WriteLine(String);
            Console.WriteLine(Bool);

            //Opdracht 19
            Int = int.Parse(Console.ReadLine());

            //Opdracht 20
            Console.WriteLine(Int);
            Console.ReadKey();

            //Opdracht 21
            //in het begin worden de variables bepaald en vervolgens worden de de variables verander doordat ik een ander getal invul.
        }
    }
}
