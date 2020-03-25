using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int initialNumber = number;

            int sum = 0;

            do
            {
                int lastDigit;

                lastDigit = number % 10;

                int factorial = 1;

                for (int j = 1; j <= lastDigit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;

                number /= 10;

            } while (number != 0);

            if (sum == initialNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
