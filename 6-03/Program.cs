using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && a % 5 == 0 && a % 7 == 0)
            {
                Console.WriteLine("{0} dalinasi is 2, 5 ar 7", a);
            }
            else
            {
                Console.WriteLine("{0} nesidalina is 2, 5 ir 7", a);
            }
        }
    }
}
