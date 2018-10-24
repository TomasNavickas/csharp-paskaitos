using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var mase = new[] { 15, 165, 165, 1, 98, 6, 51, 28, 1, 1, 1, 89, 5 };
            var mase2 = new[] { 198, 16, 54, 65, 26, 65, 5 };

            int suma1 = mase.Sum();
            int suma2 = mase2.Sum();
            double vidurkis1 = suma1 / mase.Length;
            double vidurkis2 = suma2 / mase2.Length;
            Console.WriteLine(suma1);
            Console.WriteLine(suma2);
            Console.WriteLine(vidurkis1);
            Console.WriteLine(vidurkis2);

            if (vidurkis1 > vidurkis2)
            {
                Console.WriteLine(vidurkis1 + ">" + vidurkis2);
            }
            else
            {
                Console.WriteLine(vidurkis2 + ">" + vidurkis1);

            }
        }
    }
}
