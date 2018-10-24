using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite sveika taigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0 && a % 2 == 0)
            {
                Console.WriteLine("Jusu skaicius yra teigiamas ir lyginis");
            }
            else
            {
                Console.WriteLine("iveskite kita skaicius");
            }
        }
    }
}
