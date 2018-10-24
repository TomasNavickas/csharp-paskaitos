using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} > {1}",a,b);
            }
            else
            {
                Console.WriteLine("Bandykite dar kart");
            }
        }
    }
}
