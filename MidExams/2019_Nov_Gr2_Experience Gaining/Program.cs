using System;
using System.Collections.Generic;
using System.Linq;

namespace _2019_Nov_Gr2_Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal neededExperience = decimal.Parse(Console.ReadLine());

            int countOfBattles = int.Parse(Console.ReadLine());

            decimal totalGatheredExperienece = 0;

            int currentNumberOfBattle = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {

                decimal earnedExperiencePerBattle = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    totalGatheredExperienece += earnedExperiencePerBattle + (earnedExperiencePerBattle * 0.15M);
                }
                else if (i % 5 == 0)
                {
                    totalGatheredExperienece += earnedExperiencePerBattle - (earnedExperiencePerBattle * 0.1M);
                }
                else
                {
                    totalGatheredExperienece += earnedExperiencePerBattle;
                }

                currentNumberOfBattle++;

                if (totalGatheredExperienece >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {currentNumberOfBattle} battles.");
                    break;
                }

                if (currentNumberOfBattle == countOfBattles)
                {
                    decimal moreNeededExperience = neededExperience - totalGatheredExperienece;

                    Console.WriteLine($"Player was not able to collect the needed experience, {moreNeededExperience:F2} more needed.");
                }
            }

        }
    }
}
