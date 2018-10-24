using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_22_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Asile, sakiau teigiama");
            }
            if (a > 0)
            {
                Console.WriteLine("Maladiec");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} skaicius yra lyginis", a);
            }
            if (a % 4 == 0)
            {
                Console.WriteLine("{0} dalinasi is 4", a);
            }
            if (a > 10)
            {
                Console.WriteLine("{0} yra didesnis nei 10", a);
            }
        }
    }
}
