using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int vowelsNumber = CountVowels(input);

            Console.WriteLine(vowelsNumber); 
        }

        private static int CountVowels(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
