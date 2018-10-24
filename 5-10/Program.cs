using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite betkoki skaiciu");
            var a = Convert.ToDouble(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Jusu skaicius yra lyginis");
            }
            else
            {
                Console.WriteLine("Jusu skaicius yra nelyginis");
            }
        }
    }
}
