using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command;

            while ((command = Console.ReadLine()) != "find")
            {
                char[] input = command.ToCharArray();

                StringBuilder renewInput = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    for (int keyIndex = 0; keyIndex < key.Length; keyIndex++)
                    {
                        if (i >= input.Length)
                        {
                            break;
                        }

                        char currentChar = input[i];

                        int currentKeyValue = key[keyIndex];

                        int newCharAsciiNum = currentChar - currentKeyValue;

                        char currentNewChar = (char) newCharAsciiNum;

                        renewInput.Append(currentNewChar);

                        i++;
                    }

                    i--;
                }

                string renewedStringInput = renewInput.ToString();

                string[] renewedStringInputArray = renewedStringInput.Split('&', '<', '>').ToArray();

                string treasure = renewedStringInputArray[1];
                string location = renewedStringInputArray[3];

                Console.WriteLine($"Found {treasure} at {location}");

            }

        }
    }
}
