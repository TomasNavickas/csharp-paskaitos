using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.kiek(8);
            Console.WriteLine("--");
            p.kiek(15);
            Console.WriteLine("--");
            p.kiek(127);
        }
        public void kiek(int a)
        {
            var kiek = a;
            Random rand = new Random();
            var skaiciai = new List<int>();
            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(rand.Next(100));
            }
            foreach (var s in skaiciai)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
