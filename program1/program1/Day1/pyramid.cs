﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day1
{
    internal class pyramid
    {
        public static void print()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int l = 0; l < 10 - i; l++) { Console.Write(" "); }



                for (int k = i; k > 0; k--)
                {
                    if (k != 1)
                    {
                        Console.Write(k);
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

