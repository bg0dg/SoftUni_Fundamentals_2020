using System;
using System.Text;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string[] firstArr = firstString.Split();
            string[] secondtArr = secondString.Split();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < secondtArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondtArr[i] == firstArr[j])
                    {
                        output.Append(secondtArr[i] + " ");
                    }
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
