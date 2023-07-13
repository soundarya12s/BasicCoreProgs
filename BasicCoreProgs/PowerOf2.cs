using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class PowerOf2
    {
        public void powerOf(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + Math.Pow(2, i));
            }


        }
    }
}
