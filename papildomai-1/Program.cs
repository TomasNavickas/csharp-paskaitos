using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papildomai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite atsitiktini teigiama skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(skaicius);
                skaicius--;
            } while (skaicius!=0);

        }
    }
}
