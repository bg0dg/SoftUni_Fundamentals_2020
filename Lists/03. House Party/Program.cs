using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFInputs = int.Parse(Console.ReadLine());
            List<string> namesList = new List<string>();

            for (int i = 0; i < numberOFInputs; i++)
            {
                List<string> inputStringList = ReadStringsList();

                string personName = inputStringList[0];
                string direction = DefineDirection(inputStringList[2]); //goes in / goes out

                DoAction(namesList, personName, direction);
            }

            PrintNamesList(namesList);
        }

        static void PrintNamesList(List<string> namesList)
        {
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }

        static void DoAction(List<string> namesList, string personName, string direction)
        {

            if (direction == "goes in")
            {
                if (namesList.Contains(personName))
                {
                    Console.WriteLine($"{personName} is already in the list!");
                }
                else
                {
                    namesList.Add(personName);
                }
            }

            if (direction == "goes out")
            {
                if (namesList.Contains(personName))
                {
                    namesList.Remove(personName);
                }
                else
                {                   
                    Console.WriteLine($"{personName} is not in the list!");
                }
            }
        }

        private static string DefineDirection(string directionInput)
        {
            string direction = "";

            if (directionInput == "not")
            {
                direction = "goes out";
            }
            else
            {
                direction = "goes in";
            }

            return direction;
        }

        static List<string> ReadStringsList()
        {
            return Console.ReadLine().Split().ToList();
        }
    }
}
