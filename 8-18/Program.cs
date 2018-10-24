using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var sumaLyg = 0;
            var sumNelyg = 0;
            
            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    sumaLyg += a;
                }
                else
                {
                    sumNelyg += a;
                }
                a++;
            }
            Console.WriteLine("Suma lyginiu = " + sumaLyg);
            Console.WriteLine("Suma lneyginiu = " + sumNelyg);
        }
    }
}
