using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day1
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter your age:");
            String ageAsStrings=Console.ReadLine();
            int age=int.Parse(ageAsStrings);
            if(age<18)
            {
                Console.WriteLine("SORRY!! you can't drive");
            }
            else
            {
                Console.WriteLine("You can drive");
            }
        }
    }
}
