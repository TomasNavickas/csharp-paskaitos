using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_24_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} > {1}",a,b);
            }
            else if (c > a)
            {
                Console.WriteLine("{1} > {0}", a, c);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
            else if (b == c)
            {
                Console.WriteLine("{0} = {1}", b, c);
            }
        }
    }
}
