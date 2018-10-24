using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            Console.WriteLine("Iveskite desimt skaiciu:");
            Console.WriteLine();
            var viso = 0;

            do
            {
                var skaicius = Convert.ToInt32(Console.ReadLine());
                skaiciai.Add(skaicius);
                viso++;
            } while (viso != 10);
            foreach (var sk in skaiciai)
            {
                Console.Write(sk + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
