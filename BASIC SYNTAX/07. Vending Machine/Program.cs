using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "Start")
            {
                switch (input)
                {
                    case "0.1": sum += 0.1; break;
                    case "0.2": sum += 0.2; break;
                    case "0.5": sum += 0.5; break;
                    case "1": sum += 1; break;
                    case "2": sum += 2; break;

                    default: Console.WriteLine($"Cannot accept {input}"); break;
                }
                input = Console.ReadLine();
            }

            string withdraw = Console.ReadLine().ToLower();

            while (withdraw != "end")
            {
                if (withdraw == "nuts")
                {
                    if (sum - 2.0 >= 0)
                    {
                        Console.WriteLine($"Purchased {withdraw}");
                        sum -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (withdraw == "water")
                {
                    if (sum - 0.7 >= 0)
                    {
                        Console.WriteLine($"Purchased {withdraw}");
                        sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (withdraw == "crisps")
                {
                    if (sum - 1.5 >= 0)
                    {
                        Console.WriteLine($"Purchased {withdraw}");
                        sum -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (withdraw == "soda")
                {
                    if (sum - 0.8 >= 0)
                    {
                        Console.WriteLine($"Purchased {withdraw}");
                        sum -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (withdraw == "coke")
                {
                    if (sum - 1.0 >= 0)
                    {
                        Console.WriteLine($"Purchased {withdraw}");
                        sum -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid product");
                }

                withdraw = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change:{sum: 0.00}");
        }
    }
}
