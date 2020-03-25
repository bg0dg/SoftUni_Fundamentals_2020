using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;

            int currentPosition = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] commands = command.Split(' ').ToArray();

                int length = int.Parse(commands[1]);

                int newPossition;

                if (currentPosition + length > intList.Length - 1)
                {
                    currentPosition = 0;
                    newPossition = currentPosition;
                }

                else
                {
                    newPossition = currentPosition + length;
                }

                int currentCell = intList[newPossition];

                if (currentCell == 0)
                {
                    Console.WriteLine($"Place {newPossition} already had Valentine's day.");
                }

                else
                {
                    currentCell -= 2;

                    intList[newPossition] = currentCell;

                    if (currentCell == 0)
                    {
                        Console.WriteLine($"Place {newPossition} has Valentine's day.");
                    }

                }

                currentPosition = newPossition;
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");

            int counter = 0;

            int noZeroCounter = 0;
            
            for (int i = 0; i < intList.Length; i++)
            {
                if (intList[i] == 0)
                {
                    counter++;
                }
                else
                {
                    noZeroCounter++;
                }
            }

            bool isAllHappy = false;

            if (counter == intList.Length)
            {
                isAllHappy = true;
            }

            if (isAllHappy)
            {
                Console.WriteLine("Mission was successful.");
            }

            if (isAllHappy != true)
            {
                Console.WriteLine($"Cupid has failed {noZeroCounter} places.");
            }
        }
    }
}
