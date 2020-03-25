using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string firstString = input[0];
            string secondString = input[1];

            PrintSumOfMultipiedChars(firstString, secondString);
        }

        private static void PrintSumOfMultipiedChars(string firstString, string secondString)
        {
            int fisrtStringLength = firstString.Length;
            int secondStringLength = secondString.Length;

            int minStringLength = Math.Min(fisrtStringLength, secondStringLength);
            int maxStringLength = Math.Max(fisrtStringLength, secondStringLength);

            int sum = 0;

            for (int i = 0; i < maxStringLength; i++)
            {
                if (i < minStringLength)
                {
                    int multipiedValue = 0;

                    multipiedValue = firstString[i] * secondString[i];

                    sum += multipiedValue;
                }
                else
                {
                    if (fisrtStringLength > minStringLength)
                    {
                        sum += firstString[i];
                    }
                    else if (secondStringLength > minStringLength)
                    {
                        sum += secondString[i];
                    }
                }

            }

            Console.WriteLine(sum);
        }
    }
}
