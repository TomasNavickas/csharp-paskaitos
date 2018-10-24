using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_23_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} yra lyginis, ir pakeltas 5-uoju = " + Math.Pow(a,5),a);
            }
            if (a % 4 != 0)
            {
                Console.WriteLine("Iveskite kita skaiciu");
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = " + (a + b), a, b);
                Console.WriteLine("{0} * {1} = " + (a * b), a, b);
            }
        }
    }
}
