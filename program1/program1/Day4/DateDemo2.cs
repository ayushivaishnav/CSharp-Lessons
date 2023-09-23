using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day4
{
    internal class DateDemo2
    {
        public static void FindRetirementDate()
        {
            Console.WriteLine("What is your Date of Birth(yyyy/mm/dd)");
            String strdob=String.Empty;
            try
            {
                strdob = $"{Console.ReadLine()}";
                DateTime dob = DateTime.Parse(strdob);
                DateTime nextMonthDate=dob.AddYears(60).AddMonths(1);
                DateTime retirementdate = new DateTime(nextMonthDate.Year, nextMonthDate.Month, 1);
                Console.WriteLine("Your Retirement date is " + retirementdate.ToShortDateString());
                                    
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR:{ex.Message}");
            }
        }
    }
}
