using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasikite penkis skaicius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var d = Convert.ToDouble(Console.ReadLine());
            var e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu skaiciu vidurkis = " + ((a+b+c+d+e)/5));
            // arba
            var vidurkis = (a + b + c + d + e) / 5;
            Console.WriteLine("Jusu skaiciu vidurkis = " + vidurkis);

        }
    }
}
