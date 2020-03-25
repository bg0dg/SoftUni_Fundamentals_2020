using System;
using System.Collections.Generic;
using System.Linq;

namespace _2019_Nov_Gr2_Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfTanks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split(", ").ToArray();

                string firstCommandWord = commandLine[0];
                string secondCommandWord = commandLine[1];            

                if (firstCommandWord == "Add")
                {
                    string tankName = secondCommandWord;

                    bool isTankExists = listOfTanks.Contains(tankName);

                    if (isTankExists)
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");

                        listOfTanks.Add(tankName);
                    }
                }

                else if (firstCommandWord == "Remove" && secondCommandWord != "At") //Remove
                {
                    string tankName = secondCommandWord;

                    bool isTankExists = listOfTanks.Contains(tankName);

                    if (isTankExists)
                    {
                        Console.WriteLine("Tank successfully sold");
                        listOfTanks.Remove(tankName);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");     
                    }
                }

                else if (firstCommandWord == "Remove At") //Remove At
                {
                    int index = int.Parse(secondCommandWord);

                    bool isInxedInRange = false;

                    if (index >= 0 && index < listOfTanks.Count)
                    {
                        isInxedInRange = true;
                    }

                    if (isInxedInRange)
                    {
                        listOfTanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }

                else if (firstCommandWord == "Insert")
                {
                    string thirdCommandWord = commandLine[2];
                    int index = int.Parse(secondCommandWord);
                    string tankName = thirdCommandWord;

                    bool isInxedInRange = false;
                    bool isTankExists = listOfTanks.Contains(tankName);

                    if (index >= 0 && index < listOfTanks.Count)
                    {
                        isInxedInRange = true;
                    }

                    if (isInxedInRange && isTankExists == false)
                    {
                        listOfTanks.Insert(index, tankName);
                        Console.WriteLine("Tank successfully bought");
                    }

                    else if (isInxedInRange && isTankExists == true)
                    {
                        Console.WriteLine("Tank is already bought");
                    }

                    else if (isInxedInRange == false)
                    {
                        Console.WriteLine("Index out of range");
                    }
                }

            }

            Console.WriteLine(string.Join(", ", listOfTanks));
        }
    }
}
