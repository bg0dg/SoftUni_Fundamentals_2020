using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intergerList = ReadInputLineIntList();

            List<int> finalIntegersList = DoIntegersListActions(intergerList);

            PrintFinalIntegersList(finalIntegersList);
        }

        static void PrintFinalIntegersList(List<int> finalIntegersList)
        {
            Console.WriteLine(String.Join(" ", finalIntegersList));
        }

        static List<int> DoIntegersListActions(List<int> intergerList)
        {
            List<int> intergerListTemp = intergerList;

            string command = ReadInputString();

            while (command != "end")
            {
                string[] commandsArray = MakeStringToArray(command);
                string firstCommandElement = commandsArray[0];
                int secondCommandElement = 0;
                int thirdCommandElement = 0;

                if (commandsArray.Length == 2)
                {
                    secondCommandElement = int.Parse(commandsArray[1]);
                }
                else if (commandsArray.Length == 3)
                {
                    secondCommandElement = int.Parse(commandsArray[1]);
                    thirdCommandElement = int.Parse(commandsArray[2]);
                }

                if (firstCommandElement == "Insert")
                {
                    intergerListTemp.Insert(thirdCommandElement, secondCommandElement);
                }
                else if (firstCommandElement == "Delete")
                {
                    while (intergerListTemp.Contains(secondCommandElement))
                    {
                        intergerListTemp.Remove(secondCommandElement);
                    }                   
                }

                command = ReadInputString();
            }

            return intergerListTemp;
        }

        static string[] MakeStringToArray(string command)
        {
            string[] stringArray = command.Split().ToArray();
            return stringArray;
        }

        static string ReadInputString()
        {
            string readString = Console.ReadLine();
            return readString;
        }

        static List<int> ReadInputLineIntList()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            return wagons;
        }
    }
}
