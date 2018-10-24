using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i >= 20 && i % 2 == 0) 
                {
                    suma += i;
                }
            }

            Console.WriteLine("lyginiu skaiciu suma nuo 20 iki 50 lygi: " + suma);

            // antras sprendimo varinatas

            var suma2 = 0;

            for (int i = 20; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    suma2 += i;
                }
            }

            Console.WriteLine("lyginiu skaiciu suma nuo 20 iki 50 lygi: " + suma2);
        }
    }
}
