using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var preke = new[] { "ledai", "trintukas", "knyga", "kava" };
            var kaina = new[] { 0.99, 0.2, 14.99, 1.29 };
            var i = 0;
            var j = 0;
            Console.WriteLine("+-----------+-------+");
            Console.WriteLine("| Produktas | Kaina |");
            foreach (var pr in preke)
            {
                Console.WriteLine("+-----------+-------+");
                Console.WriteLine("|{0,-10} | {1,-5} |",preke[i], kaina[j]);
                i++;
                j++;
            }
            Console.WriteLine("+-----------+-------+");

        }
    }
}
