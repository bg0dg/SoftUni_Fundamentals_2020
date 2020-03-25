using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = new int[3];

            for (int i = 0; i < inputNums.Length; i++)
            {
                inputNums[i] = int.Parse(Console.ReadLine());
            }

            Smallest_of_Three_Numbers(inputNums[0], inputNums[1], inputNums[2]);

        }

        private static void Smallest_of_Three_Numbers(int n1, int n2, int n3)
        {
            int midNum = Math.Min(n1, n2);
            int minNum = Math.Min(midNum, n3);
            Console.WriteLine(minNum);          
        }
    }
}
