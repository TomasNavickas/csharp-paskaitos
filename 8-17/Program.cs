using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 25;

            while (skaicius >= 25 && skaicius <= 50)
            {
                if (skaicius % 3 != 0)
                {
                    Console.WriteLine(skaicius);
                }
                else
                {
                    Console.WriteLine("dalinasi is 3");
                }
                skaicius++;
            }
        }
    }
}
