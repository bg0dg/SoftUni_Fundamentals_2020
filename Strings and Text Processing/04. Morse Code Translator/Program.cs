using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> alphabet = new Dictionary<string, char>
            {
                [".-"] = 'A',
                ["-..."] = 'B',
                ["-.-."] = 'C',
                ["-.."] = 'D',
                ["."] = 'E',
                ["..-."] = 'F',
                ["--."] = 'G',
                ["...."] = 'H',
                [".."] = 'I',
                [".---"] = 'J',
                ["-.-"] = 'K',
                [".-.."] = 'L',
                ["--"] = 'M',
                ["-."] = 'N',
                ["---"] = 'O',
                [".--."] = 'P',
                ["--.-"] = 'Q',
                [".-."] = 'R',
                ["..."] = 'S',
                ["-"] = 'T',
                ["..-"] = 'U',
                ["...-"] = 'V',
                [".--"] = 'W',
                ["-..-"] = 'X',
                ["-.--"] = 'Y',
                ["--.."] = 'Z'
            };

            string message = Console.ReadLine();

            string[] words = message.Split('|').ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            StringBuilder convertedMessage = new StringBuilder();

            foreach (var morseWord in words)
            {

                string[] morseWordSimbols = morseWord.Split(' ').ToArray();

                foreach (var simbol in morseWordSimbols)
                {
                    char convertedSimblolToLetter = alphabet[simbol];
                    convertedMessage.Append(convertedSimblolToLetter);
                }

                convertedMessage.Append(" ");
            }

            Console.WriteLine(convertedMessage);
        }
    }
}
