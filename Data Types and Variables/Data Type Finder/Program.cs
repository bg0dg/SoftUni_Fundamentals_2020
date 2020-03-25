using System;
using System.Runtime.Intrinsics.X86;

namespace Data_Type_Finder
{
    class Program
    {
        private static bool res;

        static void Main(string[] args)
        {
            string input = null;
            
            while (true)
            {
                input = Console.ReadLine();

                if (input == "END" || input == "")
                {
                    return;
                }

                int a;

                double b;

                Char ch;

                bool boo;

                res = int.TryParse(input, out a);

                if (res == true)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else
                {
                    res = double.TryParse(input, out b);

                    if (res == true)
                    {
                        Console.WriteLine($"{input} is floating point type");
                    }

                    else
                    {
                        res = bool.TryParse(input, out boo);

                        if (res == true)
                        {
                            Console.WriteLine($"{input} is boolean type");
                        }

                        else
                        {
                            res = Char.TryParse(input, out ch);

                            if (res == true)
                            {
                                Console.WriteLine($"{input} is character type");
                            }
                            else
                            {
                                Console.WriteLine($"{input} is string type");
                            }
                        }
                    }
                }
            }
        }
    }
}
