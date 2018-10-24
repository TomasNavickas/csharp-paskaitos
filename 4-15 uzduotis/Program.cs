using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo varda: ");
            var vardas = Console.ReadLine();
            Console.Write("Iveskite savo pavarde: ");
            var pav = Console.ReadLine();
            Console.Write("Iveskite gimimio datą: ");
            var gim = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite kuo dirbate: ");
            var darb = Console.ReadLine();
            Console.Write("Iveskite savo etata: ");
            var etat = Console.ReadLine();
            Console.Write("Iveskite savo atlyginimą eurais: ");
            var eur = Console.ReadLine();

            double amzius = (2018 - gim);

            Console.WriteLine("{0} {1} (" + amzius + "m.) dirba {2} {3} etatu ir uzdirba {4}eur/men.", vardas, pav, darb, etat, eur);


        }
    }
}
