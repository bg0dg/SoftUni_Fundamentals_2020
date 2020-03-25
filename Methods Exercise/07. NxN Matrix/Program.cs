using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            PrintNxN_Matrix(inputNum);
        }

        private static void PrintNxN_Matrix(int inputNum)
        {
            for (int i = 0; i < inputNum; i++)
            {
                for (int j = 1; j <= inputNum; j++)
                {
                    Console.Write(inputNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
