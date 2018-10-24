using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 5, 15, 61, 6151, 15, 61, 51, 61, 351619, 6161849, 1, 23, 47, 651, 515, 31, 651, 884, };
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write("a" + skaiciai[i] + "s");
            }
        }
    }
}
