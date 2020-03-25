using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();

            //var dict = new Dictionary<char, int>();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character != ' ')
                {
                    if (!dict.ContainsKey(character))
                    {
                        dict.Add(character, 1);
                    }
                    else
                    {
                        dict[character]++;
                    }
                }              
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
