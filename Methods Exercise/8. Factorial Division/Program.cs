using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal firstNumResult = CalculateFactorial(firstNum);
            decimal secondNumResult = CalculateFactorial(secondNum);

            DevideFactsAndPrint(firstNumResult, secondNumResult);
        }

        private static void DevideFactsAndPrint(decimal firstNumResult, decimal secondNumResult)
        {
            decimal result = firstNumResult / secondNumResult;

            Console.WriteLine($"{result:F2}");
        }

        private static decimal CalculateFactorial(decimal num)
        {
            decimal result = 1;

            while (num != 0)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}
