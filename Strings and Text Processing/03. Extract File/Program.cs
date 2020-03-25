using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();

            string fileNameAndExtention = input[input.Length - 1];

            string[] fileNameAndExtentionArray = fileNameAndExtention.Split('.').ToArray();

            string fileName = fileNameAndExtentionArray[0];
            string extention = fileNameAndExtentionArray[1];

            Console.WriteLine($"File name: {fileName}");  
            Console.WriteLine($"File extension: {extention}");  
        }
    }
}
