using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 7 6 2 19 23
            // 8
            //
            //     1 7
            //     6 2

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int patternNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    int firstNum = numbers[i];
                    int SecondNum = numbers[k];
                    int sum = firstNum + SecondNum;

                    if (sum == patternNum)
                    {
                        Console.Write(firstNum + " ");
                        Console.WriteLine(SecondNum);
                    }
                }
            }

        }
    }
}
