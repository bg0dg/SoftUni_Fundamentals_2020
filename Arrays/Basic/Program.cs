using System;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allocating an array of 10 integers
            int[] numbers = new int[10];

            //An array that stores string elements can be declared in the same way:
            string[] names = new string[10];

            //The Length holds the number of array elements
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = 1;

            //The[] operator accesses elements by index
            numbers[5] = numbers[2] + numbers[7];
            numbers[10] = 1; // IndexOutOfRangeException

            string[] days = {
              "Monday",
              "Tuesday",

              "Sunday"
            };

            //Next, create an array of given size n and read its elements:
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Arrays can be read from a single line of separated values
            //2 8 30 25 40 72 -2 44 56
            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
                arr[i] = int.Parse(items[i]);

            //Read an array of integers (using System.LINQ;):
            var inputLine = Console.ReadLine();
            string[] items = inputLine.Split(', ');
            int[] arr = items.Select(int.Parse).ToArray();

            int[] arr = Console.ReadLine().Split(', ')
             .Select(int.Parse).ToArray();

            //Printing Arrays:

            //Use for-loop:
            int[] arr = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            //Use string.Join(separator, array):
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", arr)); // 1, 2, 3
            string[] strings = { "one", "two" };
            Console.WriteLine(string.Join(" - ", strings)); // one - two


            //Reversing array elements (exchange):

            var items = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < items.Length / 2; i++)
            {
                var oldElement = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = oldElement;
            }

            Console.WriteLine(string.Join(" ", items));

            //Print an Array with Foreach

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }


        }
    }
}
