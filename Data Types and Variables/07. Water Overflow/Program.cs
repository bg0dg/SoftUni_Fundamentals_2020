using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int tankQty = 0;

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                int currentQty = tankQty;
                currentQty += int.Parse(Console.ReadLine());

                if (currentQty > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    currentQty = tankQty;
                }
                else
                {
                    tankQty = currentQty;
                }

                if (i == numberOfLines)
                {
                    Console.WriteLine(tankQty);
                }
            }
        }
    }
}
