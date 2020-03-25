using System;
using System.Text;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string leftSideString = GetLeftSideStrings(input);
                string rightSideString = GetRightSideStrings(input);

                bool arePalindromeEqual = CompareBothSides(leftSideString, rightSideString);

                PrintResult(arePalindromeEqual);

                input = Console.ReadLine();
            }
        }

        private static void PrintResult(bool arePalindromeEqual)
        {
            if (arePalindromeEqual == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool CompareBothSides(string left, string right)
        {
            return left == right;
        }

        private static string GetRightSideStrings(string input)
        {
            StringBuilder rightSide = new StringBuilder();

            if (input.Length % 2 == 0)
            {
                for (int i = input.Length - 1; i >= input.Length / 2; i--)
                {
                    rightSide.Append(input[i]);
                }
            }

            else
            {
                for (int i = input.Length - 1; i > input.Length / 2; i--)
                {
                    rightSide.Append(input[i]);
                }
            }

            return rightSide.ToString();
        }

        private static string GetLeftSideStrings(string input)
        {
            StringBuilder leftSide = new StringBuilder();

            for (int i = 0; i < input.Length / 2; i++)
            {
                leftSide.Append(input[i]);
            }

            return leftSide.ToString();
        }
    }
}
