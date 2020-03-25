using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployCapacity = int.Parse(Console.ReadLine()); 
            int secondEmployCapacity = int.Parse(Console.ReadLine()); 
            int thirdEmployCapacity = int.Parse(Console.ReadLine()); 

            int numberOfclients = int.Parse(Console.ReadLine());

            int totalcapacity = firstEmployCapacity + secondEmployCapacity + thirdEmployCapacity;

            int sumOfCapacity = 0;

            int counter = 0;

            if (sumOfCapacity > numberOfclients)
            {
                counter = 1;
            }

            while (sumOfCapacity < numberOfclients)
            {
                
                counter++;

                if (counter % 4 == 0)
                {
                    continue;
                }

                sumOfCapacity += totalcapacity;

            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
