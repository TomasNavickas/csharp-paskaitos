using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            var rand = new Random();
            Console.WriteLine("Kiek skaiciu?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(rand.Next(1,100));
            }
            foreach (var sk in skaiciai)
            {
                Console.WriteLine(sk);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("maziausias: " + skaiciai.Min());
        }
    }
}
