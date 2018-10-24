using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}
