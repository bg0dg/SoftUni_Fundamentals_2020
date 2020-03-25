using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          

            for (int i = 0; i < n; i++)
            {
                for (int J = 0; J < n; J++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char first = (char)('a'+ i);
                        char second = (char)('a' + J);
                        char third = (char)('a' + k);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
