using System;
using System.Collections.Generic;
using System.Linq;

namespace _2019_Nov_Gr2_Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NameList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string command;

            while ((command = Console.ReadLine()) != "Report")
            {
                string[] commandWords = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string commandWord = commandWords[0];

                if (commandWord == "Blacklist")
                {
                    string name = commandWords[1];

                    bool isNameExists = NameList.Contains(name);
                    int namePosition = Array.IndexOf(NameList, name);

                    if (isNameExists)
                    {
                        NameList[namePosition] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }

                else if (commandWord == "Error")
                {
                    int index = int.Parse(commandWords[1]);

                    string nameAtIndex = NameList[index];

                    if (nameAtIndex != "Blacklisted" && nameAtIndex != "Lost")
                    {
                        NameList[index] = "Lost";

                        Console.WriteLine($"{nameAtIndex} was lost due to an error.");
                    }
                }

                else if (commandWord == "Change")
                {
                    int index = int.Parse(commandWords[1]);
                    string newName = commandWords[2];

                    bool isIndexInRange = false;

                    if (index >= 0 && index < NameList.Length)
                    {
                        isIndexInRange = true;
                    }

                    if (isIndexInRange)
                    {
                        string currentName = NameList[index];

                        NameList[index] = newName;

                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }

                }
            }

            int BleckListedNames = 0;

            foreach (string name in NameList.Where(x => x == "Blacklisted"))
            {
                BleckListedNames++;
            }

            int LostNames = 0;

            foreach (string name in NameList.Where(x => x == "Lost"))
            {
                LostNames++;
            }

            Console.WriteLine($"Blacklisted names: {BleckListedNames}");
            Console.WriteLine($"Lost names: {LostNames}");

            Console.WriteLine(string.Join(" ", NameList));
        }
    }
}
