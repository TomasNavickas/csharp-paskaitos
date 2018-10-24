using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random(); // jei skaicius turi buti atsitiktinis
            var skaicius = 1;

            while (skaicius % 3 != 0 || skaicius % 5 != 0)
            {
                Console.WriteLine(skaicius);
                skaicius = rand.Next(1,100);
            }
        }
    }
}
