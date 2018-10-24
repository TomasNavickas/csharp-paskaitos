using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} dalinasi is 2", a);
            }
            else if (a % 3 ==0)
            {
                Console.WriteLine("{0} dalinasi is 3", a);
            }
            else if (a % 4 == 0)
            {
                Console.WriteLine("{0} dalinasi is 4", a);
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("{0} dalinasi is 5", a);
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("{0} dalinasi is 7", a);
            }
            else
            {
                Console.WriteLine("{0} nesidalina is 2, 3, 4, 5 ar 7.", a);
            }
        }
    }
}
