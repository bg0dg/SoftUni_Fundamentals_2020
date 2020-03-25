using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;

            for (int currentIndex = 0; currentIndex < numArray.Length; currentIndex++)
            {
                int sumLeft = 0;

                for (int k = currentIndex - 1; k >= 0; k--)
                {
                    sumLeft += numArray[k];
                }

                int sumRight = 0;

                for (int k = currentIndex + 1; k < numArray.Length; k++)
                {
                    sumRight += numArray[k];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(currentIndex);
                    isEqual = true;
                }
            }
            
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
