using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var masyvas = new int[5];
            masyvas[0] = 5;
            masyvas[1] = 6;
            masyvas[2] = 7;
            masyvas[3] = 3;
            masyvas[4] = 2;

            var suma = 0;

            foreach (var skaicius in masyvas)
            {
                suma += skaicius;
            }
            
            double vidurkis = suma / masyvas.Length;

            Console.WriteLine(suma);
            Console.WriteLine();
            Console.WriteLine(vidurkis);
        }
    }
}
