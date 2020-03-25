using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int maxDivisor = 1;

            for (int i = 2; i <= 10; i++)
            {
                if (i == 2 || i == 3 || i == 6 || i == 7 || i == 10)
                {
                    if (input % i == 0)
                    {
                        maxDivisor = i;
                    }
                }
            }

            if (maxDivisor != 1)
            {
                Console.WriteLine($"The number is divisible by {maxDivisor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
