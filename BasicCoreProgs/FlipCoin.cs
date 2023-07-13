using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects
{
    public class Coin
    {
        Random random = new Random();
        public void flip(int n)
        {
            int tails = 0, heads = 0;
            for (int i = 0; i < n; i++)
            {
                double coinflip = random.NextDouble();


                if (coinflip < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }

            }

            Console.WriteLine((heads * 100) / n);
            Console.WriteLine((tails * 100) / n);

        }
    }

}
