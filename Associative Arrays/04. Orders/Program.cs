using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productDict = new Dictionary<string, ProductPriceQty>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commands = command.Split(' ').ToArray();

                string name = commands[0];
                decimal price = decimal.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                if (!productDict.ContainsKey(name))
                {
                    ProductPriceQty prodPriceQty = new ProductPriceQty(price, quantity);

                    productDict.Add(name, prodPriceQty);
                }
                else
                {
                    productDict[name].Price = price; //take "Price" property of "ProductPriceQty" value 

                    productDict[name].Qty += quantity;
                }
            }

            foreach (var kvp in productDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Price * kvp.Value.Qty:F2}");
            }           
        }
    }

    class ProductPriceQty
    {
        public ProductPriceQty(decimal price, int quantity)
        {
            Price = price;
            Qty = quantity;
        }

        public decimal Price { get; set; }
        public int Qty { get; set; }    
    }
}
