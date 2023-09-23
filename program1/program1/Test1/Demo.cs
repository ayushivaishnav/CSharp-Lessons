using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Test1
{
    internal class Demo
    {
        public static void  DoTask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }

        public static void DoTaskA(ref int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }

    }
}
