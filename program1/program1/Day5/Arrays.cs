using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day5
{
    public class Arrays
    {
        private static object sample;

        public static void FirstMethod()
        {
            int[] sample = new int[10];
            //int a[] = new int[10]; // Illigal
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i * 5;
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }
        
    }
}
