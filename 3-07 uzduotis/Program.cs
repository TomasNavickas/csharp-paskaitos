using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 1;

            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));
            Console.WriteLine(a + " * " + b + " = " + (a*b++));

            //arba

            var c = 6;
            var d = 1;

            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);
            Console.WriteLine("{0} * {1} = " + (c * d), c, d++);

        }
    }
}
