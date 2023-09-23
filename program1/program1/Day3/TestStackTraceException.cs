﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day3
{
     class TestStackTraceException
    {
        public static void TestStackTrace()
        {
            ClassA a1 = null;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            try
            {
                Console.WriteLine("Enter a no X");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another no Y");
                v2 = int.Parse(Console.ReadLine());
                a1 = new ClassA();
                v3 = a1.M1(v1, v2);
                Console.WriteLine("Result of {0}/{1}={2}", v1, v2, v3);
            }
            catch (Exception err)
            {
                Console.WriteLine("Error1 StackTrace:\n " + err.StackTrace);
                Console.WriteLine("Error1 TargetSite:\n " + err.TargetSite.Name);
            }
        }
        class ClassA
        {
            public int M1(int x, int y)
            {
                ClassB b1 = new ClassB();
                return b1.M2(x, y);
            }
        }
        class ClassB
        {
            public int M2(int x, int y)
            {
                Calculator c1 = new Calculator();
                return c1.Divide(x, y);
            }
        }
        class Calculator
        {
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }



            public int DivideA(int x, int y)
            {
                //if (y == 0)
                //    throw new ZeroValueException();
                //if (y == 0)
                //    throw new ZeroValueException("ERROR!!! Value for Y is " + y);
                return x / y;
            }
        }
    }
}
