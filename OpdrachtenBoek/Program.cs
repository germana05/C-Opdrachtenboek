using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Program
    {
        //opdracht 40
        static int Int = 1;
        static char Char;
        static string String = "2";

        //opdracht 41
        static char Char2 = '3';
        static int Int2;
        static int Int3;

        //opdracht 42
        static char Char3 = '4';
        static int Int4;

        static void Main(string[] args)
        {

            //opdracht 41
            Char = (char)Int32.Parse(Int.ToString());
            Int2 = Int32.Parse(Char2.ToString());
            Int3 = Int32.Parse(String);

            //opdracht 43

        }
    }
}
