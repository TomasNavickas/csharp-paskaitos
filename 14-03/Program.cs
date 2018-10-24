using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.suma(14, 15);
            pro.skirtumas(81, 30);
            pro.sandauga(22, 11);
            pro.dalmuo(18, 130);
            Console.WriteLine("--");
            pro.suma(-8, 155);
            pro.skirtumas(11, 18);
            pro.sandauga(14, 90);
            pro.dalmuo(7, 3);

        }
        public void suma(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public void skirtumas(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void sandauga(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public void dalmuo(double a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, Math.Round(a / b, 3));
            // Math.Round prie rezultato leidzia suapvalinti rezultata, po kablelio rasome, kiek skaiciu po kablelio tikimes
        }
    }
}
