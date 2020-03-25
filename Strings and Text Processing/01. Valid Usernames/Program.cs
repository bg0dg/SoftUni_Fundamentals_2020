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

            PrintValidUserNames(userNames);
        }

        private static void PrintValidUserNames(string[] userNames)
        {
            foreach (var username in userNames)
            {
                bool isUsernameValid = true;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (var simbol in username)
                    {
                        if (!(char.IsLetterOrDigit(simbol) || simbol == '_' || simbol == '-'))
                        {
                            isUsernameValid = false;
                        }
                    }

                    if (isUsernameValid)
                    {
                        Console.WriteLine(username);
                    }

                }
            }
        }
    }
}
