using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_18_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Skaiciai {0} ir {1}, yra lygus", a, b);
            }
            if (a == c)
            {
                Console.WriteLine("Skaiciai {0} ir {1}, yra lygus", a, c);
            }
            if (a > b)
            {
                Console.WriteLine("Skaicius {0} yra daugiau uz {1}", a, b);
            }
            if (a > c * 2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz dviguba treciojo reiksme {1}", a, c);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", a);
            }
            if (b % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} yra nelyginis", b);
            }
            if (c > 0)
            {
                Console.WriteLine("Skaicius {0} yra teigiamas", c);
            }
            if (a < 0)
            {
                Console.WriteLine("Skaicus {0} yra nelyginis", a);
            }
            if (b % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 4", b);
            }
            if (c % 8 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is 8", c);
            }
        }
    }
}
