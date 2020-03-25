using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productPriceDict = new Dictionary<string, decimal>();
            var productQtyDict = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commands = command.Split(' ').ToArray();

                string name = commands[0];
                decimal price = decimal.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                if (!productQtyDict.ContainsKey(name))
                {
                    productQtyDict[name] = 0;
                    productPriceDict[name] = 0;
                }

                productQtyDict[name] += quantity;
                productPriceDict[name] = price;
            }

            foreach (var kvp in productQtyDict)
            {
                string currentName = kvp.Key; //Making relation between both Dictionaries!

                decimal currentPrice = productPriceDict[currentName];
                int currentQty = productQtyDict[currentName];

                decimal totalPrice = currentPrice * currentQty;

                Console.WriteLine($"{kvp.Key} -> {totalPrice}");
            }
        }
    }
}
