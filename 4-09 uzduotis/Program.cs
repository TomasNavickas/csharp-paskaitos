using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_09_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a +b ));
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            // arba
            var skirt = a - b;
            var suma = a + b;
            var dalmuo = a / b;
            var sandauga = a * b;
            Console.WriteLine("{0} - {1} = " + skirt,a, b );
            Console.WriteLine("{0} + {1} = " + suma,a, b );
            Console.WriteLine("{0} * {1} = " + sandauga,a, b );
            Console.WriteLine("{0} / {1} = " + dalmuo, a, b );


        }
    }
}
