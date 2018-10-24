using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            int skaicius = p.grazinimas(9, 8);
            Console.WriteLine(skaicius);

        }
        public int grazinimas(int a, int b)
        {
            var sk = 0;

            if (a > b)
            {
                a = sk;
            }
            else if (a < b)
            {
                b = sk;
            }
            else if (a == b)
            {
                b = sk;
            }

            return sk;

        }
    }
}
