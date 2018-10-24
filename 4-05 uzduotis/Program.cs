using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda.");
            var vardas = Console.ReadLine();
            Console.WriteLine("Koks jusu amzius?");
            var amzius = Console.ReadLine();
            Console.WriteLine("Jus esate vardu " + vardas + ". Jums yra " + amzius + " metai.");

        }
    }
}
