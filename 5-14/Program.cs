using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else if (b > a)
            {
                Console.WriteLine("{1} > {0}", a, b);
            }
            else
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
        }
    }
}
