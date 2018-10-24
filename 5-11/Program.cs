using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var a = Convert.ToDouble(Console.ReadLine());
            if (a % 7 == 0)
            {
                Console.WriteLine("{0} dalinaisi is 7",a);
            }
            else
            {
                Console.WriteLine("Pasirinkite kita skaiciu");
            }
        }
    }
}
