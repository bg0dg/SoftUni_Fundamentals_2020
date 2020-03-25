using System;

namespace _2019_Nov_Gr1_Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsAmountPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int monthlyBiscuitsAmountCompetitor = int.Parse(Console.ReadLine());

            int totalAmount = 0;
            int totalAmountPerDayNormal = biscuitsAmountPerDay * countOfWorkers;
            int totalAmountPerDayReduced = (int)(biscuitsAmountPerDay * countOfWorkers * 0.75);

            totalAmount = totalAmountPerDayNormal * 20 + totalAmountPerDayReduced * 10;

            int difference = totalAmount - monthlyBiscuitsAmountCompetitor;

            decimal diffInPercentage = 0;

            string sign = "";

            if (difference > 0)
            {
                diffInPercentage = (decimal) difference / monthlyBiscuitsAmountCompetitor * 100;

                sign = "more";
            }
            else if (difference < 0)
            {
                difference = Math.Abs(difference);
                diffInPercentage = (decimal) difference / monthlyBiscuitsAmountCompetitor * 100;
                sign = "less";
            }

            Console.WriteLine($"You have produced {totalAmount} biscuits for the past month.") ;

            Console.WriteLine($"You produce {diffInPercentage:F2} percent {sign} biscuits.");
        }
    }
}
