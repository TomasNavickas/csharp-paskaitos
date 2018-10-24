using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite simboli: ");
            var sum = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine("{0} {0} {0}", sum);
            Console.WriteLine("{0}   {0}", sum);
            Console.WriteLine("{0} {0} {0}", sum);


        }
    }
}
