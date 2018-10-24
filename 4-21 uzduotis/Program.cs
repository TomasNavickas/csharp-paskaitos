using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_21_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atsitiktini skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 5 == 0)
            {
                double b = 1;
                Console.WriteLine("{0} * 1 = " + a*b++, a);
                Console.WriteLine("{0} * 2 = " + a*b++, a);
                Console.WriteLine("{0} * 3 = " + a*b++, a);
                Console.WriteLine("{0} * 4 = " + a*b++, a);
                Console.WriteLine("{0} * 5 = " + a*b++, a);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} kvadratu = " + a * a, a);
                Console.WriteLine("{0} kvadratas / 2 = " + a * a / 2, a);
            }
            if (a % 7 != 0)
            {
                var b = 45;
                Console.WriteLine("{0} * {1} = " + (a * b), a, b);
                Console.WriteLine("{0} / {1} = " + (a * b), a, b);
                Console.WriteLine("{0} + {1} = " + (a * b), a, b);
                Console.WriteLine("{0} + {1} = " + (a * b), a, b);
            }
        }
    }
}
