using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueType()
        {
            byte b = 125;
            Console.WriteLine(b);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            float f1 = 52.678f;
            Console.WriteLine(f1);
            long l1 = int.MaxValue + 1000L;
            Console.WriteLine(l1);
            double d1 = 6565d;
            Console.WriteLine(d1);
            char c1 = 'A';
            Console.WriteLine(c1);
            bool flag = true;
            Console.WriteLine(flag);



            int x = c1;
            Console.WriteLine(x);

        }
        public static void TestMethod()
        {
            Console.WriteLine("Test");
        }

       
    }
}
