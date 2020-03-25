using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while (command != "End")
            {
                string[] commandsArray = MakeStringToArray(command);
                string firstCommandElement = commandsArray[0];
                string secondCommandElement = "";
                int thirdCommandElement = 0;

                if (commandsArray.Length == 2)
                {
                    secondCommandElement = commandsArray[1];
                }
                else if (commandsArray.Length == 3)
                {
                    secondCommandElement = commandsArray[1];
                    thirdCommandElement = int.Parse(commandsArray[2]);
                }


                if (firstCommandElement == "Add")
                {
                    intergerListTemp.Add(int.Parse(secondCommandElement));
                }

                else if (firstCommandElement == "Insert")
                {                   
                    if (thirdCommandElement > intergerListTemp.Count || thirdCommandElement < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        intergerListTemp.Insert(thirdCommandElement, int.Parse(secondCommandElement));
                    }
                }

                else if (firstCommandElement == "Remove")
                {
                    if (int.Parse(secondCommandElement) > intergerListTemp.Count || int.Parse(secondCommandElement) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        intergerListTemp.RemoveAt(int.Parse(secondCommandElement));
                    }
                }

                else if (firstCommandElement == "Shift")
                {
                    int shiftCounter = thirdCommandElement % intergerList.Count;

                    if (secondCommandElement == "left")
                    {
                        for (int i = 0; i < shiftCounter; i++)
                        {
                            intergerListTemp.Add(intergerListTemp[0]);
                            intergerListTemp.RemoveAt(0);
                        }

                    }

                    else if (secondCommandElement == "right")
                    {
                        for (int i = 0; i < shiftCounter; i++)
                        {
                            intergerListTemp.Insert(0, intergerListTemp[intergerListTemp.Count - 1]);
                            intergerListTemp.RemoveAt(intergerListTemp.Count - 1);
                        }
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
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            return inputList;
        }
    }
}
