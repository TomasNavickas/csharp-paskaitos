using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var kartai = 0;
            int suma = 0;
            int atsitiktinis;

            while (kartai < 100)
            {
                atsitiktinis = rand.Next();
                suma += atsitiktinis;
                Console.Write(atsitiktinis + ", ");
                kartai++;
            }
            Console.WriteLine();
            Console.WriteLine("suma = " + suma);
            var vidurkis = suma / 100;
            Console.WriteLine("vidurkis = " + vidurkis);
        }
    }
}
