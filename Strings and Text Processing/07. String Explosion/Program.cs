using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main()
        {
            //abv>1>1>2>2asdasd
            //abv>>>>dasd

            string input = Console.ReadLine();

            int bomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString()); 
                }

                if (bomb > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    bomb--; // One bomb is used
                    i--;  
                }

            }

            Console.WriteLine(input);
        }
    }
}