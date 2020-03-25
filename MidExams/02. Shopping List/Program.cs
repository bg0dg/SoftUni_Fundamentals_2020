using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> initialList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] inputCommands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstCommandWord = inputCommands[0];
                string secondCommandWord = inputCommands[1];

                string thirdCommandWord;

                if (firstCommandWord == "Urgent")
                {
                    string item = secondCommandWord;

                    bool isItemExist = initialList.Contains(item);

                    if (isItemExist == false)
                    {
                        initialList.Insert(0, item);
                    }

                }

                else if (firstCommandWord == "Unnecessary")
                {
                    string item = secondCommandWord;

                    bool isItemExist = initialList.Contains(item);

                    if (isItemExist)
                    {
                        initialList.Remove(item);
                    }
                }

                else if (firstCommandWord == "Correct")
                {
                    thirdCommandWord = inputCommands[2];
                    string oldItem = secondCommandWord;
                    string newItem = thirdCommandWord;

                    bool isItemExist = initialList.Contains(oldItem);

                    if (isItemExist )
                    {
                        int currentItemPosition = initialList.IndexOf(oldItem);

                        initialList[currentItemPosition] = newItem;
                    }
                }

                else if (firstCommandWord == "Rearrange")
                {
                    string item = secondCommandWord;

                    bool isItemExist = initialList.Contains(item);

                    if (isItemExist)
                    {
                        int currentItemPosition = initialList.IndexOf(item);

                        initialList.Add(item);

                        initialList.RemoveAt(currentItemPosition);                     
  
                    }
                }
            }

            Console.WriteLine(string.Join(", ", initialList));
        }
    }
}
 