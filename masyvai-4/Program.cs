using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 0;
            var suma = 0;
            int daliklis = 0;
            do
            {
                if (skaicius % 2 != 0)
                {
                    Console.WriteLine(skaicius);
                    suma += skaicius;
                    daliklis++;
                }
                skaicius++;
            } while (skaicius % 50 != 0);
            Console.WriteLine(suma);
            Console.WriteLine("vidurkis= " + suma/daliklis);
        }
    }
}
