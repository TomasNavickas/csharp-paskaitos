using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_071
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1; // kai skaiciai is eiles

            while (skaicius % 3 != 0 || skaicius % 5 != 0)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }
    }
}
