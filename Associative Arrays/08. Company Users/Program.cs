using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployeesId = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                //SoftUni -> AA12345

                string[] inputs = input.Split("->").ToArray(); //Use input, not Console.ReadLine() !!!

                string companyName = inputs[0].Trim();
                string employeeId = inputs[1].Trim();

                if (!companyEmployeesId.ContainsKey(companyName))
                {
                    companyEmployeesId[companyName] = new List<string>();
                }

                if (!companyEmployeesId[companyName].Contains(employeeId))
                {
                    companyEmployeesId[companyName].Add(employeeId);
                }               
            }

            foreach (var kvp in companyEmployeesId.OrderBy(kvp => kvp.Key))
            {
                string companyName = kvp.Key;

                Console.WriteLine(companyName);

                foreach (var employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }

            }

        }
    }
}
