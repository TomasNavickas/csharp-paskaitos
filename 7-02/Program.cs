using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo role puslapyje:\nvartotojas - 1 \nmoderatorius - 2 \nadministratorius - 3");
            var role = Convert.ToInt32(Console.ReadLine());
            switch (role)
            {
                case 1:
                    Console.WriteLine("gero narsymo");
                    break;
                case 2:
                    Console.WriteLine("sveiki moderatoriau");
                    break;
                case 3:
                    Console.WriteLine("sveiki administratoriau");
                    break;
                default:
                    Console.WriteLine("pasirinkite role is pateiktu");
                    break;
            }
        }
    }
}
