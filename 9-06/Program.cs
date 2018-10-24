using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomas = new Random();
            var kiekis = 0;
            var suma = 0;
            while (kiekis <= 10)
            {
                var skaicius = randomas.Next(1, 50);
                suma += skaicius;
                kiekis++;
            }
            Console.WriteLine(suma);
        }
    }
}
