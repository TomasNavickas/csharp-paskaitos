using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet kokius tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jusu skaiciai: " + a + " " + b + " " + c);
            //arba
            Console.WriteLine("Jusu skaiciai: {0} {1} {2}", a, b, c);
            Console.WriteLine("Jusu skaiciai kvadratu: " + (a * a) + " " + (b * b) + " " + (c * c)); // arba galime panaudoti math.pow
            Console.WriteLine("Jusu skaiciai treciuoju laipsiu: " + Math.Pow(a, 3) + " " + Math.Pow(b, 3) + " " + Math.Pow(c, 3));
            Console.WriteLine("Jusu skaiciai padalinti per pus: " + (a/2) + " " + (b/2) + " " + (c/2));

        }
    }
}
