using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int product = 0;

            int reminder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int num1Int = int.Parse(num1[i].ToString()); // char => string => int

                int num2Int = num2;

                product = num1Int * num2Int + reminder;

                if (product < 10)
                {
                    result.Append(product);
                    reminder = 0;
                }

                else
                {
                    result.Append((product) % 10);
                    reminder = product / 10;

                    if (i == 0)
                    {
                        result.Append(reminder);
                    }
                }

            }

            Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').ToCharArray().Reverse()));
        }
    }
}
