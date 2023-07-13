using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class Factors
    {
        public void factors(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
