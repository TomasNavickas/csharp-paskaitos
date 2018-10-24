using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("{0} + {1} + {2} = " + (a + b + c), a, b, c);
                    break;
                case 2:
                    Console.WriteLine("{0} * {1} = " + (b * c), b, c);
                    break;
                case 3:
                    Console.WriteLine("{0} * {0} = " + (Math.Pow(a, 2)), a);
                    break;
                default:
                    Console.WriteLine("pasirinkite kitus skaicius");
                    break;
            }
        }
    }
}
