using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite triju egzaminu rezultatus");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vid = (a + b + c) / 3;
            if (vid <= 10 && vid >= 8)
            {
                Console.WriteLine("Vidurkis tarp 8 ir 10");
            }
            if (vid < 8 && vid >= 5)
            {
                Console.WriteLine("vidurkis yra tarp 5 ir 7");
            }
            if (vid < 5)
            {
                Console.WriteLine("Vidurkis maziau uz 5");
            }

        }
    }
}
