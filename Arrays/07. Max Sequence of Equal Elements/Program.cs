using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int counter = 1;
            string maxNumber = "";
            int maxCounter = 1;

            for (int i = input.Length - 1; i > 0; i--)
            {
                string current = input[i];
                string next = input[i - 1];
         
                if (current == next)
                {
                    counter++;

                    if (maxCounter <= counter)
                    {
                        maxCounter = counter;
                        maxNumber = current;
                    }                   
                }
                else
                {
                    counter = 1;
                }             
            }
           
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(maxNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
