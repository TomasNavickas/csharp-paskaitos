using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // reikia be daugybos parasyti dvieju skaiciu daugyba
            Console.WriteLine("iveskite du skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            /*pasinaudojam tuo, kad sandauga yra tam tikra kieki kartu sudeti skaiciai
             20 = 4 + 4 + 4 + 4 + 4
             arba
             20 = 5 + 5 + 5 + 5
             tai mes galime deti viena is skaiciu prie 0 tiek kartu, kiek yra kitas skaicius*/

            var sand = 0;            
            
            for (int i = 0; i < a; i++)
            {
                sand += b;
            }
            Console.WriteLine(sand);


        }
    }

}

