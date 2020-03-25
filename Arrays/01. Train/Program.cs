using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] peopleInWagons = new int[n];

            int sumOfPeople = 0;

            for (int i = 0; i < peopleInWagons.Length; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());

                sumOfPeople += peopleInWagons[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(peopleInWagons[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sumOfPeople);

            //Console.WriteLine(peopleInWagons.Sum()); Sum of array elements - using Ling !!!
        }
    }
}
