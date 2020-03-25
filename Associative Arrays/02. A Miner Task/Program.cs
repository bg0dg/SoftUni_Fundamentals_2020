using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<string> inputList = new List<string>();
        
            Dictionary<string, long> resourceDict = new Dictionary<string, long>();

            while ((input = Console.ReadLine()) != "stop")
            {
                inputList.Add(input);
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                if (i % 2 == 0) //odd lines
                {
                    string resource = inputList[i];

                    if (!resourceDict.ContainsKey(resource))
                    {
                        resourceDict.Add(resource, 0);
                    }                  
                }
                else
                {
                    string resource = inputList[i - 1];
                    long quantity = long.Parse(inputList[i]);

                    resourceDict[resource] += quantity;
                }
            }

            foreach (var kvp in resourceDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
