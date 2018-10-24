using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            var kiek = 100;
            var rand = new Random();
            var suma = 0;
            var lyginiai = 0;

            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(rand.Next(100));
            }
            foreach (var sk in skaiciai)
            {
                Console.Write(sk + " ");
                suma += sk;
                if (sk % 2 == 0)
                {
                    lyginiai++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("paskutinis " + skaiciai.Last());
            Console.WriteLine("atsitiktinis " + skaiciai[rand.Next(kiek - 1)]);
            Console.WriteLine("maziausias " + skaiciai.Min());
            Console.WriteLine("didziausias " + skaiciai.Max());
            Console.WriteLine("skaiciu suma " + suma);
            Console.WriteLine("vidurkis " + ((double)suma / kiek));
            Console.WriteLine("vidurkis " + skaiciai.Average());
            Console.WriteLine("lyginiu skaiciu " + lyginiai);

        }
    }
}
