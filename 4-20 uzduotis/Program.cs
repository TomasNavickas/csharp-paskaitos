using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_20_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo metinius pazymiu vidurkius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var d = Convert.ToDouble(Console.ReadLine());
            var e = Convert.ToDouble(Console.ReadLine());
            if ((a+b+c+d+e)/5 >= 5)
            {
                Console.WriteLine("Jusu metinis vidurkis teigiamas");
            }
        }
    }
}
