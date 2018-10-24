using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki sveika skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = 1;
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            // arba galima panaudoti {0} kintamaji
        }
    }
}
