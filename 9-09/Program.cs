using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            int skaicius = 1;

            while (skaicius <= 10)
            {
                sandauga *= skaicius;
                skaicius++;
            }
            Console.WriteLine(sandauga);
        }
    }
}
