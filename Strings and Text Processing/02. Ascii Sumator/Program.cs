using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int smalerChar = Math.Min(firstChar, secondChar);
            int greaterChar = Math.Max(firstChar, secondChar);

            char[] input = Console.ReadLine().ToCharArray();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar > smalerChar && currentChar < greaterChar)
                {
                    sum += (int)currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
