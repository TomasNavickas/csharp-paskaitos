using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} didziausias", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} didziausias", b);
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("{0} didziausias", c);
            }
            else
            {
                Console.WriteLine("Skaiciai lygus");
            }
        }
    }
}