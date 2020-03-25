using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            printMiddleChars(input);
        }

        private static void printMiddleChars(string input)
        {
            if (IsLengthEven(input))
            {
                PrintEven(input);
            }
            else
            {
                PrintOdd(input);
            }
            
        }

        private static void PrintOdd(string input)
        {
            int inputLength = input.Length - 1;
            int middleCharPosition = inputLength / 2;

            Console.WriteLine($"{input[middleCharPosition]}");
        }

        private static void PrintEven(string input)
        {
            int inputLength = input.Length - 1;
            int middleCharPosition = inputLength / 2;

            Console.WriteLine($"{input[middleCharPosition]}{input[middleCharPosition + 1]}");
        }

        private static bool IsLengthEven(string input)
        {
            if (input.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
