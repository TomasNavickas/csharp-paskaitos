using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 3;
            var suma = a + b;
            var skirtumas = a - b;

            Console.WriteLine(suma);
            Console.WriteLine(skirtumas);
            Console.WriteLine(suma * skirtumas);
            Console.WriteLine(suma / skirtumas);

        }
    }
}
