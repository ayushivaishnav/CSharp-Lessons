using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day3
{
    internal class Box1
    {
        public int Height;
        public int Width;
        public int Length;


        public Box1(int x) //constructor
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height},Length:{Length},Width{Width}";
        }
    }
    internal class WoodenBox : Box1 //inheritance
   {
        public int Area;
       public WoodenBox( ):base(1)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x): base(x)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x,int y) : base(x)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box shifted");
        }
        public override string ToString() // Print values into given string
        {
            return "Tom and Jerry";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
        }
            public static void TestTwo()
            {
                WoodenBox box = new WoodenBox();
                box.Height = 100;
                box.Width = 50;
                box.Length = 200;
                box.Open();
                box.Close();
                String output = box.ToString();
                Console.WriteLine(output);
                box.Area = 300;
                box.Move();
            }
        public static void TestThree()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Width = 50;
            box.Length = 200;
            box.Open();
            box.Close();
            String output = box.ToString();//tom and jerry
           
            Console.WriteLine(output);
            //box.Area = 300;
           // box.Move();
        }

    }
}
