using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            StringBuilder encriptedPass = new StringBuilder();

            foreach (var character in pass)
            {
                char shiftedChar = (char)(character + 3);

                encriptedPass.Append(shiftedChar);
            }

            Console.WriteLine(encriptedPass);
        }
    }
}
