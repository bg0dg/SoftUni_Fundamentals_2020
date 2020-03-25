using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.None).ToArray();

            foreach (var username in userNames)
            {
                if (ValidateUserNames(username))
                {
                    Console.WriteLine(username);
                }
            }

        }

        private static bool ValidateUserNames(string userNames)
        {

            if (userNames.Length < 3 || userNames.Length > 16)
            {
                return false;
            }

            foreach (var symbol in userNames)
            {
                if (!(char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
