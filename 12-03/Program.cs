using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var markes = new List<string>();
            markes.Add("VW");
            markes.Add("Mercedes");
            markes.Add("Audi");
            markes.Add("SAAB");
            markes.Add("Volo");

            var kiek = markes.Count();
            for (int i = 0; i < kiek; i++)
            {
                Console.Write(markes[i] + ", ");
            }
        }
    }
}
