using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] numbers = input.Select(int.Parse).ToArray();

            int numberOfrotations = int.Parse(Console.ReadLine());

            int[] positions = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                positions[i] = i;
            }

            for (int i = 0; i < numberOfrotations; i++)
            {
                for (int j = 0; j < positions.Length; j++)
                {
                    if (positions[j] < positions.Length - 1)
                    {
                        positions[j] += 1;
                    }
                    else
                    {
                        positions[j] = 0;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[positions[i]]} ");
            }

            Console.WriteLine();
        }
    }
}
