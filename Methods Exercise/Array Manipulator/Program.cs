using System;
using System.Linq;
using System.Text;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] innitialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int innitialArrayLength = innitialArray.Length;

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandElements = TakeCommandElements(command);
                string firstCommandElement = AddCommandElement(commandElements, 1);
                string secondCommandElement = AddCommandElement(commandElements, 2);
                string thirdCommandElement = AddCommandElement(commandElements, 3);

                if (firstCommandElement == "exchange")
                {
                    CommandExchange(secondCommandElement, innitialArray);
                }

                else if (firstCommandElement == "min" || firstCommandElement == "max")
                {
                    ReturnIndexMinMaxEvenOddElement(firstCommandElement, secondCommandElement, innitialArray);
                }

                else if (firstCommandElement == "first" || firstCommandElement == "last")
                {
                    FirstLastCountElements(firstCommandElement, secondCommandElement, thirdCommandElement, innitialArray);
                }

                //---------------------------
                command = Console.ReadLine();
            }

        }

        private static void FirstLastCountElements(string firstCommandElement, string secondCommandElement, string thirdCommandElement, int[] innitialArray)
        {
            if (firstCommandElement == "first")
            {
                if (int.Parse(secondCommandElement) > innitialArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    StringBuilder result = new StringBuilder();

                    int counter = 0;

                    if (thirdCommandElement == "even")
                    {
                            for (int i = 0; i < innitialArray.Length; i++)
                            {
                                while (counter != int.Parse(secondCommandElement))
                                {
                                    if (innitialArray[i] % 2 == 0)
                                    {
                                        result.Append(innitialArray[i] + " ");
                                        counter++;
                                    }
                                }
                            }


                        Console.WriteLine($"[{string.Join(", ", result)}]");

                        Console.WriteLine();
                    }

                    else if (secondCommandElement == "odd")
                    {
                        for (int i = 0; i < int.Parse(secondCommandElement); i++)
                        {
                            if (innitialArray[i] % 2 != 0)
                            {
                                result.Append(innitialArray[i]);
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", result)}]");
                    }
                }
            }

            else if (firstCommandElement == "last")
            {
                if (int.Parse(secondCommandElement) > innitialArray.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    StringBuilder result = new StringBuilder();

                    if (thirdCommandElement == "even")
                    {
                        for (int i = innitialArray.Length - 1; i > innitialArray.Length - int.Parse(secondCommandElement); i--)
                        {
                            if (innitialArray[i] % 2 == 0)
                            {
                                result.Append(innitialArray[i]);
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", result)}]");
                    }

                    else if (secondCommandElement == "odd")
                    {
                        for (int i = innitialArray.Length - 1; i > innitialArray.Length - int.Parse(secondCommandElement); i--)
                        {
                            if (innitialArray[i] % 2 != 0)
                            {
                                result.Append(innitialArray[i]);
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", result)}]");
                    }
                }
            }


        }

        private static void ReturnIndexMinMaxEvenOddElement(string firstCommandElement, string secondCommandElement, int[] innitialArray)
        {
            if (firstCommandElement == "max")
            {
                int eventIndex = -1;
                int eventValue = 0;

                if (secondCommandElement == "even")
                {
                    for (int i = 0; i < innitialArray.Length; i++)
                    {
                        if (innitialArray[i] % 2 == 0)
                        {
                            if (innitialArray[i] >= eventValue && innitialArray[i] != 0)
                            {
                                eventValue = innitialArray[i];
                                eventIndex = i;
                            }
                        }
                    }
                }

                else if (secondCommandElement == "odd")
                {
                    for (int i = 0; i < innitialArray.Length; i++)
                    {
                        if (innitialArray[i] % 2 != 0)
                        {
                            if (innitialArray[i] >= eventValue && innitialArray[i] != 0)
                            {
                                eventValue = innitialArray[i];
                                eventIndex = i;
                            }
                        }
                    }
                }

                if (eventIndex == -1 )
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(eventIndex);
                }
            }

            if (firstCommandElement == "min")
            {
                int eventIndex = -1;
                int eventValue = int.MaxValue;

                if (secondCommandElement == "even")
                {
                    for (int i = 0; i < innitialArray.Length; i++)
                    {
                        if (innitialArray[i] % 2 == 0)
                        {
                            if (innitialArray[i] <= eventValue && innitialArray[i] != 0)
                            {
                                eventValue = innitialArray[i];
                                eventIndex = i;
                            }
                        }
                    }
                }

                else if (secondCommandElement == "odd")
                {
                    for (int i = 0; i < innitialArray.Length; i++)
                    {
                        if (innitialArray[i] % 2 != 0)
                        {
                            if (innitialArray[i] <= eventValue && innitialArray[i] != 0)
                            {
                                eventValue = innitialArray[i];
                                eventIndex = i;
                            }
                        }
                    }
                }

                if (eventIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(eventIndex);
                }
            }
        }

        private static void CommandExchange(string secondCommandElement, int[] innitialArray)
        {
            int exchangeIndex = int.Parse(secondCommandElement);

            if (exchangeIndex > innitialArray.Length - 1 || exchangeIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            int[] coppiedArrayLeft = innitialArray.Take(exchangeIndex + 1).ToArray();
            int[] coppiedArrayRight = innitialArray.Skip(exchangeIndex + 1).ToArray();

            coppiedArrayRight.CopyTo(innitialArray, 0);
            coppiedArrayLeft.CopyTo(innitialArray, coppiedArrayRight.Length);

            Console.WriteLine();
        }

        private static string AddCommandElement(string[] commandElements, int numberOfElement)
        {
            string returnedCommand = "";
            
            if (numberOfElement == 1)
            {
                returnedCommand = commandElements[0];
            }

            else if (numberOfElement == 2)
            {
                returnedCommand = commandElements[1];
            }

            else if (numberOfElement == 3)
            {
                if (commandElements.Length == 3)
                {
                    returnedCommand = commandElements[2];
                }
            }

            return returnedCommand;
        }

        private static string[] TakeCommandElements(string command)
        {
            string[] commandElements = command.Split().ToArray();

            return commandElements;
        }
    }
}
