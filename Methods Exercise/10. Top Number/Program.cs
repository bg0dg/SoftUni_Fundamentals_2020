using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            CheckRangeForTopNums(range);

        }

        static void CheckRangeForTopNums(int range)
        {
            for (int i = 1; i < range; i++)
            {
                string currentNum = i.ToString();

                if (IsSumDevisibleByEight(currentNum) && HasOddDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        static bool HasOddDigit(string currentNum)
        {
            for (int i = 0; i < currentNum.Length; i++)
            {
                if (currentNum[i] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsSumDevisibleByEight(string currentNum)
        {
            int sum = 0;

            for (int i = 0; i < currentNum.Length; i++)
            {
                int digit = int.Parse(currentNum[i].ToString());

                sum += digit;
            }

            return sum % 8 == 0;
        }
    }
}
