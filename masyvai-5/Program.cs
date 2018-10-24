using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int skaicius;
            do
            {
                skaicius = rand.Next(100);
                Console.WriteLine(skaicius);
                
            } while (skaicius % 3 != 0);
        }
    }
}
