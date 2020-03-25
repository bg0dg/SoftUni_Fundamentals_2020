using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = ReadInputLineIntList();

            int capacity = ReadInputInt();

            List<int> finalWagonsState = DoWagonActions(wagons, capacity);

            PrintWagonsAndPassangers(finalWagonsState);
        }

        static void PrintWagonsAndPassangers(List<int> finalWagonsState)
        {
            Console.WriteLine(String.Join(" ", finalWagonsState));
        }

        static List<int> DoWagonActions(List<int> wagons, int capacity)
        {
            List<int> wagonsTemp = wagons;

            string command = ReadInputString();

            while (command != "end")
            {
                string[] commandsArray = MakeStringToArray(command);
                int secondCommandElement = 0;

                string firstCommandElement = commandsArray[0];
                if (commandsArray.Length > 1)
                {
                    secondCommandElement = int.Parse(commandsArray[1]);
                }
                
                if (firstCommandElement == "Add")
                {
                    wagonsTemp.Add(secondCommandElement);
                }
                else
                {
                    int numberOfNewPassangers = int.Parse(firstCommandElement);

                    for (int i = 0; i < wagonsTemp.Count; i++)
                    {
                        int currentWagonPassangersNumber = wagonsTemp[i];

                        if (currentWagonPassangersNumber + numberOfNewPassangers <= capacity)
                        {
                            wagonsTemp[i] = currentWagonPassangersNumber + numberOfNewPassangers;
                            break;
                        }
                    }
                }

                command = ReadInputString();
            }

            return wagonsTemp;
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

        static int ReadInputInt()
        {
            int capacity = int.Parse(Console.ReadLine());

            return capacity;
        }

        static List<int> ReadInputLineIntList()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            return wagons;
        }
    }
}
