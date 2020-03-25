using System;
using System.Collections.Generic;
using System.Linq;

namespace _2019_Nov_Gr1_Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> givenCards = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> newDeck = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "Ready")
            {

                string[] commandWords = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstCommandWord = commandWords[0];
                string secondCommandWord = commandWords[1];
                string thirdCommandWord = "";

                if (commandWords.Length > 2)
                {
                    thirdCommandWord = commandWords[2];
                }


                if (firstCommandWord == "Add")
                {
                    AddCard(givenCards, newDeck, secondCommandWord);
                }

                else if (firstCommandWord == "Insert")
                {
                    InsertCard(givenCards, newDeck, secondCommandWord, thirdCommandWord);
                }

                else if (firstCommandWord == "Remove")
                {
                    RemoveCard(givenCards, newDeck, secondCommandWord);
                }

                else if (firstCommandWord == "Swap")
                {
                    SwapCards(newDeck, secondCommandWord, thirdCommandWord);
                }

                else if (firstCommandWord == "Shuffle")
                {
                    newDeck.Reverse();
                }

            }

            Console.WriteLine(string.Join(" ", newDeck));
        }

        private static void SwapCards(List<string> newDeck, string secondCommandWord, string thirdCommandWord)
        {
            string firstCardName = secondCommandWord;
            string secondCardName = thirdCommandWord;

            int firstCardIndex = newDeck.IndexOf(firstCardName);
            int secondCardIndex = newDeck.IndexOf(secondCardName);

            string tempString = firstCardName;

            newDeck[firstCardIndex] = newDeck[secondCardIndex];

            newDeck[secondCardIndex] = tempString;
        }

        private static void RemoveCard(List<string> givenCards, List<string> newDeck, string secondCommandWord)
        {
            string cardName = secondCommandWord;

            bool existCadrInNewDeck = newDeck.Contains(cardName);

            if (existCadrInNewDeck)
            {
                newDeck.Remove(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        private static void InsertCard(List<string> givenCards, List<string> newDeck, string secondCommandWord, string thirdCommandWord)
        {
            string cardName = secondCommandWord;
            int index = int.Parse(thirdCommandWord);

            bool existCadrInGivenCards = givenCards.Contains(cardName);

            if (existCadrInGivenCards && index >= 0 && index <= newDeck.Count - 1)
            {
                newDeck.Insert(index, cardName);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private static void AddCard(List<string> givenCards, List<string> newDeck, string secondCommandWord)
        {
            string cardName = secondCommandWord;

            bool existCadrInGivenCards = givenCards.Contains(cardName);
            bool existCadrInNewDeck = newDeck.Contains(cardName);

            if (existCadrInGivenCards == true && existCadrInNewDeck == false)
            {
                newDeck.Add(cardName);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
    }
}
