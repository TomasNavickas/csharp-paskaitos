﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 0;

            do
            {
                Console.WriteLine(skaicius);
                skaicius++;
            } while (skaicius % 17 != 0);
        }
    }
}
