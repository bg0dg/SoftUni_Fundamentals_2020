using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {

                string[] items = Console.ReadLine().Split(' ');

                int[] inputArr = items.Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = inputArr[0];
                    secondArr[i] = inputArr[1];
                }
                else
                {
                    firstArr[i] = inputArr[1];
                    secondArr[i] = inputArr[0];
                }
            }

            foreach (var num in firstArr)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            foreach (var num in secondArr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
