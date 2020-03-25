using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split("|").ToList(); //list: 1 2 3 |4 5 6 |  7  8

            List<List<string>> inputListOfLists = new List<List<string>>();

            AddElementsToNewList(inputList, inputListOfLists);

            inputListOfLists.Reverse();

            List<string> result = new List<string>();

            MergeListsInResultList(inputList, inputListOfLists, result);

            PrintResult(result);

            Console.WriteLine();

        }

        private static void PrintResult(List<string> result)
        {
            foreach (var item in result)
            {
                Console.Write(String.Join(" ", item) + " ");
            }
        }

        private static void MergeListsInResultList(List<string> inputList, List<List<string>> inputListOfLists, List<string> result)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                for (int k = 0; k < inputListOfLists[i].Count; k++)
                {
                    result.Add(inputListOfLists[i][k]);
                }
            }
        }

        private static void AddElementsToNewList(List<string> inputList, List<List<string>> inputListOfLists)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                inputListOfLists.Add(inputList[i].Split().ToList()); //inputListOfLists[0] = 1 2 3; ...

                RemoveEmptySpaces(inputListOfLists, i);
            }
        }

        private static void RemoveEmptySpaces(List<List<string>> inputListOfLists, int i)
        {
            for (int k = 0; k < inputListOfLists[i].Count; k++)
            {
                if (inputListOfLists[i][k] == "")
                {
                    inputListOfLists[i].RemoveAt(k);

                    k--;
                }
            }
        }
    }
}
