using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite simboli: ");
            var sim = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine("   {0}", sim);
            Console.WriteLine("  {0}{0}{0}", sim);
            Console.WriteLine(" {0}{0}{0}{0}{0}", sim);
            Console.WriteLine("{0}{0}{0}{0}{0}{0}{0}", sim);
        }
    }
}
