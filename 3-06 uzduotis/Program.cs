using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = -1 + 4 * 6;
            var antras = (35 + 5) % 7;
            var trecias = 14 + -4 * 6 / 11;
            var ketvirtas = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(pirmas + "\n" + antras + "\n" + trecias + "\n" + ketvirtas);

            //arba

            Console.WriteLine("{0} \n{1} \n{2} \n{3}", pirmas, antras, trecias, ketvirtas);

        }
    }
}
