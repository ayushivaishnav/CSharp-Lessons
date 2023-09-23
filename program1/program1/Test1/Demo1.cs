using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Test1
{
    internal class Demo1
    {
        public static void D()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            Demo.DoTask( v1 );
            Console.WriteLine($"v1:{v1}");
            Demo.DoTaskA(ref v1);
            Console.WriteLine($"v1:{v1}");
            
            
        }
    }
}
