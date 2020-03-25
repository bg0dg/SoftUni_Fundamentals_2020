using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayConsuming = 26;
            int dayliAmount = 0;
            int collectedAmount = 0;
            int days = 0;

            while (yield >= 100)
            {
                dayliAmount = yield - dayConsuming;
                collectedAmount += dayliAmount;

                yield -= 10;
                days++;
            }

            if (days > 0)
            {
                collectedAmount -= dayConsuming;
            }

            else
            {
                collectedAmount = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(collectedAmount);
        }
    }
}
