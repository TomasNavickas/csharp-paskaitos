using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_19_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo amziu: ");
            var metai = Convert.ToInt32(Console.ReadLine());

            if (metai >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }
        }
    }
}
