using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papildomai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string atsakymas;
            do
            {
                Console.WriteLine("iveskite su skaicius:");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("{0} + {1} = " + (a + b), a, b);
                Console.WriteLine("{0} - {1} = " + (a - b), a, b);
                Console.WriteLine("{0} * {1} = " + (a * b), a, b);
                Console.WriteLine("{0} / {1} = " + (a / b), a, b);
                Console.WriteLine();
                Console.WriteLine("ar norite testi (t/n)");
                var noriu = Console.ReadLine();
                atsakymas = noriu;
            } while (atsakymas != "n");
        }
    }
}
