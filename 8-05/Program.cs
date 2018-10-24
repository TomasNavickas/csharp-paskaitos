using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite reziu pradia:");
            var pra = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("iveskite reziu pabaiga:");
            var pab = Convert.ToInt64(Console.ReadLine());

            if (pra < pab)
            {
                for (int i = 1; i <= pab; i++)
                {
                    Console.WriteLine("{0} " + (i * i) + " ",i);
                }
            }
            else
            {
                Console.WriteLine("iveskite pabaiga didesne nei pradzia");
            }
        }
    }
}
