using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* susirandame reikiama formule, kuri naudojama isreiksti viena ar kita mato vieneta
            Tada ivesta skaiciu tiesiog istatome i reikiama formule */
            Console.WriteLine("Iveskite kabario temperatura °C: ");
            var laipsniai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu kambario temperatura °F yra: " + (laipsniai * 9/5 + 32));
            Console.WriteLine("Jusu kambario temperatura °K yra: " + (laipsniai + 273.15));

        }
    }
}
