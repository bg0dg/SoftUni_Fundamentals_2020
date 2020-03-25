using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            Operations(firstHand, secondHand);

            PrintOutput(firstHand, secondHand);
        }

        static void PrintOutput(List<int> firstHand, List<int> secondHand)
        {
            if (secondHand.Count == 0)
            {
                int sum = 0;

                foreach (var item in firstHand)
                {
                    sum += item;
                }

                Console.WriteLine($"First player wins! Sum: {sum}");
            }

            if (firstHand.Count == 0)
            {
                int sum = 0;

                foreach (var item in secondHand)
                {
                    sum += item;
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }

        static void Operations(List<int> firstHand, List<int> secondHand)
        {
            while (firstHand.Count > 0 & secondHand.Count > 0)
            {
                int currentCardFirstPlayer = firstHand[0];
                int currentCardSecondPlayer = secondHand[0];

                if (currentCardFirstPlayer > currentCardSecondPlayer)
                {
                    firstHand.Add(currentCardFirstPlayer);
                    firstHand.Add(currentCardSecondPlayer);

                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else if (currentCardFirstPlayer < currentCardSecondPlayer)
                {
                    secondHand.Add(currentCardSecondPlayer);
                    secondHand.Add(currentCardFirstPlayer);

                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else if (currentCardFirstPlayer == currentCardSecondPlayer)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }

            }
        }
    }
}
