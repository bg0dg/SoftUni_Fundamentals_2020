using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine()); // Char reading.
            char secondChar = char.Parse(Console.ReadLine());

            PrintMiddleChars(firstChar, secondChar);
        }

        private static void PrintMiddleChars(char c1, char c2)
        {
            if (c1 < c2) //It can be also realized by start = Math.MIn (c1, c2) and end = Math.Max(c1, c2)
            {
                for (int i = c1 + 1; i < c2; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = c2 + 1; i < c1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
