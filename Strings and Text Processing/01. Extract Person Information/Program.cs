using System;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) //first solution
            //{
            //    string input = Console.ReadLine();

            //    string[] name = input.Split('@', '|').ToArray();
            //    string[] age = input.Split('#', '*').ToArray();

            //    Console.WriteLine($"{name[1]} is {age[1]} years old.");
            //}

            for (int i = 0; i < n; i++) //second solution
            {
                string input = Console.ReadLine();

                int startNameIndex = input.IndexOf('@') + 1;
                int endNameIndex = input.IndexOf('|');
                int lengthOfName = endNameIndex - startNameIndex;
                string name = input.Substring(startNameIndex, lengthOfName);

                int startAgeIndex = input.IndexOf('#') + 1;
                int endAgeIndex = input.IndexOf('*');
                int lengthOfAge = endAgeIndex - startAgeIndex;
                string age = input.Substring(startAgeIndex, lengthOfAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
