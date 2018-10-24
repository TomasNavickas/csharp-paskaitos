using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = 10;
            double max = 145;
            Console.WriteLine("iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a >= min && a <= max)
            {
                Console.WriteLine("{0} yra tarp 10 ir 145",a);
            }
            else
            {
                Console.WriteLine("Iveskite kita skaiciu");
            }
        }
    }
}
