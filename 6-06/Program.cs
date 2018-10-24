using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b || a == 0)
            {
                Console.WriteLine("{0} yra daugiau nei {1}, arba = 0", a, b);
            }
            if (b > a || b == 5)
            {
                Console.WriteLine("{1} yra daugiau nei {0} arba = 5", a, b);
            }
            if (a > b && a == 20)
            {
                Console.WriteLine("{0} yra > {1} arba = 20", a, b);
            }
            if (b > a && b < 100)
            {
                Console.WriteLine("{1} yra daugiau uz {0} ir maziau uz 100",a ,b);
            }
        }
    }
}
