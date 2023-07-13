using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class HarmonicNumber
    {
        public void harNo(int n)
        {
            float sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum += (float)1 / i;
            }
            Console.WriteLine(sum);
        }
    }
}
