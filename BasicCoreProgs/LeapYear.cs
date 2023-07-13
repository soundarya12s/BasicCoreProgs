using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class LeapYear
    {
        public void Leap_Year(int year)
        {
            if ((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))

                Console.WriteLine("Leap Year");

            else
                Console.WriteLine("Not leap Year");
        }
    }
}
