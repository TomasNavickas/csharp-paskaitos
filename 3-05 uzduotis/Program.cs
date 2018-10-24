using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            var b = 2;

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " * " + b + " = " + (a * b ));
            Console.WriteLine(a + " / " + b + " = " + (a / b));

            //arba

            Console.WriteLine("{0} + {1} = " + (a + b),a , b);
            Console.WriteLine("{0} - {1} = " + (a - b),a , b);
            Console.WriteLine("{0} * {1} = " + (a * b),a , b);
            Console.WriteLine("{0} / {1} = " + (a / b),a , b);


        }
    }
}
