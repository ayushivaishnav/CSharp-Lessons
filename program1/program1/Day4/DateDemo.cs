using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day4
{
  

        internal class DateDemo

        {

            public static void FirstMethod()

            {

                Console.WriteLine(DateTime.Now);



                DateTime d1 = new DateTime(2002, 12, 25);

                Console.WriteLine(d1.ToLongDateString());

                Console.WriteLine(d1.ToShortDateString());

            }

            public static void SecondMethod()

            {

                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");

                String strdob = Console.ReadLine();

                DateTime d1 = DateTime.Parse(strdob);

                int year = d1.Year;

                Console.WriteLine("Year OF Dob " + year);

                int month = d1.Month;

                Console.WriteLine("Month OF Dob " + month);

                int day = d1.Day;

                Console.WriteLine("Day OF Dob " + day);

                DateTime d2 = d1.AddMonths(10);

                Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());

                DateTime d3 = d1.AddDays(5);

                Console.WriteLine("AddDays(5) " + d3.ToShortDateString());

                DateTime d4 = d1.AddYears(58);

                Console.WriteLine("AddYears(58) " + d4.ToShortDateString());

                DateTime d5 = d1.AddYears(-5);

                Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());

            }

        }

    }



