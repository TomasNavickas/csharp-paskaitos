using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.listai();

        }
        public void listai()
        {
            Random rand = new Random();

            var randomas1 = 0;
            var randomas2 = 0;
            var i = 0;
            do
            {
                randomas1 = rand.Next(100);
                randomas2 = rand.Next(100);
                var suma = randomas1 + randomas2;
                 Console.WriteLine("|{0,-3}|{1,-3}|{2,-4}|", randomas1, randomas2, suma);
                i++;
            }
            while (i != 5);
        }
    }
}
