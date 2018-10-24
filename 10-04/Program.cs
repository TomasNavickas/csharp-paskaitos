using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas1 = new[] { 1, 91, 19, 19, 65165, 1651, 651, };
            var mas2 = new[] { 651, 8798, 978, 01, 05, 265, 6506, 654068098, 6982, 32155, 141615, 14684, 1, 325, 5162, };
            var mas3 = new[] { 156, 0231, 171417, 479, 984, 9418 };
            Random rand = new Random();

            var mas1rez = mas1[rand.Next(mas1.Length)];
            var mas2rez = mas2[rand.Next(mas2.Length)];
            var mas3rez = mas3[rand.Next(mas3.Length)];

            if (mas1rez > mas3rez && mas1rez > mas2rez)
            {
                Console.WriteLine(mas1rez);
            }
            else if (mas2rez > mas3rez && mas2rez > mas1rez)
            {
                Console.WriteLine(mas2rez);
            }
            else if (mas3rez > mas1rez && mas3rez > mas2rez)
            {
                Console.WriteLine(mas3rez);
            }
            Console.WriteLine("rezulatas apacioj");
            Console.WriteLine(mas1rez);
            Console.WriteLine(mas2rez);
            Console.WriteLine(mas3rez);
        }
    }
}
