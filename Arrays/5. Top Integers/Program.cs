using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string topInts = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool flag = false;

                for (int n = i + 1; n < input.Length; n++)
                {
                    if (input[i] > input[n])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    topInts += input[i] + " ";
                }

                if (i == input.Length - 1)
                {
                    topInts += input[i];
                }
            }

           Console.WriteLine(string.Join(" ", topInts));
        }
    }
}
