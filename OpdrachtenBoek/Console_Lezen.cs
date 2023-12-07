using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Console_Lezen
    {
        static string userName;
        static int userAge;

        static int nummerRaden;
        static int geradenNummer;

        static void Start()
        {
            Console.WriteLine("wat is uw naam?");
            userName = Console.ReadLine();
            Console.WriteLine(userName);
            Console.ReadKey();

            Console.WriteLine("wat is uw leeftijd?");
            userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("vul een getal in die geraden moet worden.");
            nummerRaden = int.Parse(Console.ReadLine());
            Console.WriteLine("vul nu het nummer in die je denkt dat net ingevuld is.");
            geradenNummer = int.Parse(Console.ReadLine());

            if (nummerRaden == geradenNummer)
            {
                Console.WriteLine("je hebt het nummer geraden.");
                Console.ReadKey();
            }
            Console.WriteLine("je hebt het nummer niet geraden.");
            Console.ReadKey();
        }
    }
}
