using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var mase = new[] { 1,2,3,4,5,7,4,61 };
            var mase2 = new[] { 8,9,4,5,33,5,48,254,1 };
            var suma = 0;
            var suma2 = 0;

            foreach (var skaicius in mase)
            {
                suma += skaicius;
            }
            foreach (var skaicius in mase2)
            {
                suma2 += skaicius;
            }
            Console.WriteLine(suma);
            Console.WriteLine(suma2);

            if (suma>suma2)
            {
                Console.WriteLine("pirmo masyvos uma didesne");
            }
            else
            {
                Console.WriteLine("antro masyvos suma didesne");
            }
        }
    }
}
