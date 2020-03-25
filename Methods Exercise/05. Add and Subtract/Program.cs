using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int sumResult = SumFirstTwoInts(firstInt, secondInt);
            int substractresult = SubstractThirdFromResult(thirdInt, sumResult);

            Console.WriteLine(substractresult);
        }

        private static int SumFirstTwoInts(int firstInt, int secondInt)
        {
            return firstInt + secondInt;
        }

        private static int SubstractThirdFromResult(int thirdInt, int substractresult)
        {
            return substractresult - thirdInt;
        }
    }
}
