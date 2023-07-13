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

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter how many times to flip the coin:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    coin.flip(n);
                    break;
            }
            }
    }
}