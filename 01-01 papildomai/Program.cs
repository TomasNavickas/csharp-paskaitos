using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_papildomai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite trikampio krastines a ilgi");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trikampio krastines b ilgi");
            var b = Convert.ToDouble(Console.ReadLine());

            var izamkv = Math.Pow(a, 2) + Math.Pow(b, 2);

            var izam = Math.Sqrt(izamkv);

            Console.WriteLine("Trikampio izambines ilgis: " + izam);
        }
    }
}
