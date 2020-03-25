using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudentsDict = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string courseName = commands[0].Trim();
                string studentName = commands[1].Trim();

                if (!courseStudentsDict.ContainsKey(courseName))
                {
                    courseStudentsDict[courseName] = new List<string>();

                    courseStudentsDict[courseName].Add(studentName);
                }
                else
                {
                    courseStudentsDict[courseName].Add(studentName);
                }             
            }


            foreach (var kvp in courseStudentsDict.OrderByDescending(kvp => kvp.Value.Count))
            {
                string courseName = kvp.Key;
                int registeredStudents = kvp.Value.Count;

                Console.WriteLine($"{courseName}: {registeredStudents}");

                foreach (var studentName in kvp.Value.OrderBy(name => name))
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
