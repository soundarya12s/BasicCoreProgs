using System;

namespace MiniProjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose one:\n1.Coin\n2.Leap year\n3.Power of 2\n4.Harmonic number\n5.Factors\n6.Quotient&remainder\n7.Swap\n8.Even or odd\n9.Vowel or Consonant\n10.Largest among three.");
            int choice = Convert.ToInt32(Console.ReadLine());

            Coin coin = new Coin();
            LeapYear leapYear = new LeapYear();
            PowerOf2 p = new PowerOf2();
            HarmonicNumber h = new HarmonicNumber();
            Factors factors = new Factors();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter how many times to flip the coin:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    coin.flip(n);
                    break;

                case 2:
                    Console.WriteLine("Enter the year:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    leapYear.Leap_Year(y);
                    break;

                case 3:
                    Console.WriteLine("Enter the number: ");
                    int po = Convert.ToInt32(Console.ReadLine());
                    p.powerOf(po);
                    break;

                case 4:
                    Console.WriteLine("Enter the number:");
                    int hN = Convert.ToInt32(Console.ReadLine());
                    h.harNo(hN);
                    break;

                case 5:
                    Console.WriteLine("Enter the number:");
                    int N = Convert.ToInt32(Console.ReadLine());
                    factors.factors(N);
                    break;

            }
        }
    }
}