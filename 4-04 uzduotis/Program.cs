using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var pirmas = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Iveskite antra skaiciu");
            var antras = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sudejus turime: " + (pirmas + antras));
            // arba
            var suma = pirmas + antras;
            Console.WriteLine("skaiciu suma: " + suma);
        }
    }
}
