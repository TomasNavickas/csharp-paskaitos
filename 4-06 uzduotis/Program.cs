using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu skaicius " + a + " pakeltas kvadratu lygus " + (a * a));
            // arba
            Console.WriteLine("Jusu skaicius " + a + " pakeltas kvadratu lygus " + Math.Pow(a, 2));

        }
    }
}
