using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_09_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var a = Convert.ToDouble(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("Jusu ivestas skaicius yra teigiamas");
            }
            else
            {
                Console.WriteLine("Skaicius neigiamas, bandyk dar kaaaaaaaaart");
            }
        }
    }
}
