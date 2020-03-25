using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double singlePrice = 0.00;
            double totalPrice = 0.00;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 10.46;
                }

                if (number >= 30)
                {
                    singlePrice *= 0.85;
                }
            }

            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 16.00;
                }

                if (number >= 100)
                {
                    number -= 10;
                }
            }

            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    singlePrice = 15.00;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 20.00;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 22.50;
                }

                if (number >= 10 && number <= 20)
                {
                    singlePrice *= 0.95;
                }
            }

            totalPrice = number * singlePrice;

            Console.WriteLine($"Total price: {totalPrice:0.00}");

        }
    }
}
