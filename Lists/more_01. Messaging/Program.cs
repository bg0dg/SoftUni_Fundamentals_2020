using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace more_01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOFNumbers = Console.ReadLine().Split(' ', StringSplitOptions
                .RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            List<char> text = Console.ReadLine().ToList();

            StringBuilder result = new StringBuilder();

            Operations(listOFNumbers, text, result);

            Console.WriteLine(String.Join(" ", result));
        }

        private static void Operations(List<int> listOFNumbers, List<char> text, StringBuilder result)
        {
            for (int i = 0; i < listOFNumbers.Count; i++)
            {
                int sum = 0;

                int number = listOFNumbers[i];

                GetLastDigitAndREmoveItFromNumber(ref sum, ref number);

                int getIndex = GetIndex(text, sum);

                char getChar = text[getIndex];

                result.Append(getChar);

                text.RemoveAt(getIndex);
            }
        }

        private static int GetIndex(List<char> text, int sum)
        {
            int getIndex = 0;

            getIndex = sum % text.Count;
            return getIndex;
        }

        private static void GetLastDigitAndREmoveItFromNumber(ref int sum, ref int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;

                sum += lastDigit;

                number /= 10;
            }
        }
    }
}
