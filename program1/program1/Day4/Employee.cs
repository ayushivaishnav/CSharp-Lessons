using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day4
{
   
        public enum City { Chennai, Banglore, Hyderabad, Pune }
        public enum Designation { Manager, Admin, Developer }
        class Employee
        {
            public readonly int Eid;
            public string Ename = String.Empty;
            public City Ecity; //public String Ecity;
            public Designation JobTitle; //public String JobTitle
            public Employee(int v1) { Eid = v1; }
            public override String ToString()
            {
                String output = String.Empty;
                output = $"Details of the employee are: {Eid} {Ename} {Ecity} {JobTitle}";
                return output;
            }
        }
        class TestEmployee
        {
            public static void TestOne()
            {
                Employee e1 = new Employee(348);
                //e1.eid = 123;
                e1.Ename = "John";
                e1.Ecity = City.Banglore; //ecity = "Chennai";
                e1.JobTitle = Designation.Developer;//edept = "Testing";
                String output = e1.ToString();
                Console.WriteLine(output);
            }
        }
    }

