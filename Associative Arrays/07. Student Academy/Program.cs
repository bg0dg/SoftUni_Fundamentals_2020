using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGradeDict = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                decimal grade = decimal.Parse(Console.ReadLine());

                if (!studentsGradeDict.ContainsKey(name))
                {
                    studentsGradeDict[name] = new List<decimal>();
                }

                studentsGradeDict[name].Add(grade);
            }

            //{name} –> {averageGrade}

            foreach (var kvp in studentsGradeDict.Where(kvp => kvp.Value.Average() >= 4.5M).OrderByDescending(kvp => kvp.Value.Average()))
            {
                string name = kvp.Key;

                decimal averageGrade = kvp.Value.Average();

                Console.WriteLine($"{name} -> {averageGrade:F2}");
            }
        }
    }
}
