using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool checkPassLength = CheckPassLength(password);
            bool checkPassContent = CheckPassContent(password);
            bool checkPassTowDigits = CheckPassTowDigits(password);

            PrintResult(checkPassLength, checkPassContent, checkPassTowDigits);
        }

        static bool CheckPassLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

            //Or => return password.Length >= 6 && password.Length <= 10
        }

        static bool CheckPassContent(string password) //Short solution: char.IsLetterOrDigit(symbol) with foreach
        {
            for (int sym = 0; sym < password.Length; sym++)
            {
                char currSym = password[sym];

                bool firtRangeCheck = false;
                bool secondRangeCheck = false;
                bool thirdRangeCheck = false;


                if (currSym >= 48 && currSym <= 57)
                {
                    firtRangeCheck = true;
                }

                if (currSym >= 65 && currSym <= 90)
                {
                    secondRangeCheck = true;
                }

                if (currSym >= 97 && currSym <= 122)
                {
                    thirdRangeCheck = true;
                }

                if (firtRangeCheck != true && secondRangeCheck != true && thirdRangeCheck != true)
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckPassTowDigits(string password) //Short solution: char.IsDigit() with foreach
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currSym = password[i];

                if (currSym >= 48 && currSym <= 57)
                {
                    counter++;
                }

                if (counter >= 2)
                {
                    return true;
                }
            }

            return false;
        }

        static void PrintResult(bool checkPassLength, bool checkPassContent, bool checkPassTowDigits)
        {
            if (checkPassLength == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (checkPassContent == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (checkPassTowDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (checkPassLength == true && checkPassContent == true && checkPassTowDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
