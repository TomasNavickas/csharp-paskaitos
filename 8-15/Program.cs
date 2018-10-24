using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            while (skaicius <= 50)
            {
                if (skaicius % 2 == 0)
                {
                    Console.WriteLine(skaicius + " lyginis");
                }
                else
                {
                    Console.WriteLine(skaicius + " nelyginis");
                }

                skaicius++;
            }
        }
    }
}
