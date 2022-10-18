using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre âge :");
            int âge = int.Parse(Console.ReadLine());
            if (âge >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur(e)");
                Console.WriteLine("Vous serez majeur dans " + (18 - âge) + " an(s)");
            }
            Console.ReadLine();
        }
    }
}