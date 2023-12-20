using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenBoek
{
    class Console_Lezen
    {
        //Opdracht 8
        static string userName;

        //Opdracht 12
        static int userAge;

        //Opdracht 15
        static int nummerRaden;
        static int geradenNummer;

        static void Start()
        {
            //Opdracht 9
            Console.WriteLine("wat is uw naam?");

            //Opdracht 10
            userName = Console.ReadLine();

            //Opdracht 11
            Console.WriteLine(userName);
            Console.ReadKey();

            //Opdracht 13
            Console.WriteLine("wat is uw leeftijd?");

            //Opdracht 14
            userAge = int.Parse(Console.ReadLine());

            //Opdracht 15
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
