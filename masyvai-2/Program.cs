using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            do
            {
                if (skaicius % 5 == 0)
                {
                    Console.WriteLine("skaicius dalinasi is penkiu");
                }
                else
                {
                    Console.WriteLine(skaicius);
                }
                skaicius++;
            } while (skaicius % 100 != 0);
        }
    }
}
