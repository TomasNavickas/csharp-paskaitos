using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu skaiciu vidurkis: " + ((a+b+c)/3));
            // arba
            var vidurkis = (a + b + c) / 3;
            Console.WriteLine("jusu skaiciu vidurkis = " + vidurkis);

        }
    }
}
