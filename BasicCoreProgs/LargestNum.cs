using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class LargestNum
    {
        public void LargestN(int a, int b, int c)
        {
            if ((a > b) && (a > c))
            {
                Console.WriteLine(a + " is greater!");
            }
            if ((b > c) && (b > c))
            {
                Console.WriteLine(b + " is greater!");
            }
            else
                Console.WriteLine(c + " is greater!");
        }
    }
}
