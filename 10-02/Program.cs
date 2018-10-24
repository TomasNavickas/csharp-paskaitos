using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new [] {"tomas", "mantas", "jonas", "kestas", "petras", "antanas","jeronimas"};
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vardai[rand.Next(vardai.Length - 1)]); 

                // 2, 5
                // 5
            }
        }
    }
}
