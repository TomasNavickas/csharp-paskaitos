using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>();
            vardai.Add("Tomas");
            vardai.Add("Jonas");
            vardai.Add("Rimas");
            vardai.Add("Mykolas");
            foreach (var vardas in vardai)
            {
                Console.WriteLine(vardai[0]);
                Console.WriteLine(vardai[1]);
                break;
            }
        }
    }
}
