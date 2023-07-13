using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class QuoAndRem
    {
        int quo, rem;
        public void QuoRem(int num, int div)
        {
            quo = num / div;
            rem = num % div;
            Console.WriteLine("Quotient: " + quo + "\nRemainder: " + rem);
        }
    }
}
