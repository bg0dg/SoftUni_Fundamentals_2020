using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input  ;

            decimal totalCost = 0;

            List<string> furnitures = new List<string>();

            while ((input = Console.ReadLine())!= "Purchase")
            {
                string regPattern = @"\>\>(\w+)\<\<(\d*\.?\d+)!(\d+)";

                Regex regex = new Regex(regPattern);

                bool isThereAMatch = regex.IsMatch(input);

                if (isThereAMatch)
                {
                    Match match = regex.Match(input);                   

                    string prodName = match.Groups[1].ToString();

                    furnitures.Add(prodName);

                    decimal currentCost = decimal.Parse(match.Groups[2].ToString());

                    int quantity = int.Parse(match.Groups[3].ToString());

                    totalCost += currentCost * quantity;
                }
                
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furnitures)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}
