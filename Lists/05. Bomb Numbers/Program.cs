using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] inputSpecialAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int special = inputSpecialAndPower[0];
            int power = Math.Abs(inputSpecialAndPower[1]);

            DetonateNumbers(inputList, special, power);

            //Console.WriteLine(String.Join(" ", inputList)); //TEMP

            int sum = SumRestNumbers(inputList);

            Console.WriteLine(sum);
        }

        private static int SumRestNumbers(List<int> inputList)
        {
            int sum = 0;

            foreach (var num in inputList)
            {
                sum += num;
            }

            return sum;
        }

        private static void DeleteRange(int firstRangePosition, int secondRangePosition)
        {
            throw new NotImplementedException();
        }

        static int FindSecondRangePosition(List<int> inputList, int power, int i)
        {
            int specialPosition = i;

            int firstRangePos = specialPosition + power;

            if (firstRangePos > inputList.Count - 1)
            {
                firstRangePos = inputList.Count - 1;
            }

            return firstRangePos;
        }

        static int FindFirstRangePosition(List<int> inputList, int power, int i)
        {
            int specialPosition = i;

            int firstRangePos = specialPosition - power;

            if (firstRangePos < 0)
            {
                firstRangePos = 0;
            }

            return firstRangePos;
        }

        static void DetonateNumbers(List<int> inputList, int special, int power)
        {
            bool detonationFlag = false;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (special == inputList[i])
                {
                    int firstRangePosition = FindFirstRangePosition(inputList, power, i);
                    int secondRangePosition = FindSecondRangePosition(inputList, power, i);
                    int count = secondRangePosition - firstRangePosition + 1;

                    inputList.RemoveRange(firstRangePosition, count);
                    detonationFlag = true;
                }
                else
                {
                    detonationFlag = false;
                }

                if (detonationFlag == true)
                {
                    i = -1;
                }
            }
        }
    }
}
