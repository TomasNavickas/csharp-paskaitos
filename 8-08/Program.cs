using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma skaiciu nuo 1 iki 100 yra lygi: " + suma);
        }
    }
}
