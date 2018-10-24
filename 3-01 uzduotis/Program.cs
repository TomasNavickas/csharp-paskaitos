using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;

            Console.WriteLine(a * a);
            Console.WriteLine(a * a * a);

            // arba galima naudori math.pow kelti skaiciu nurodytu laipsniu
            Console.WriteLine(Math.Pow(a, 2));
            Console.WriteLine(Math.Pow(a, 3));
        }
    }
}
