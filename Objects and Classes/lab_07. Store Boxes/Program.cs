using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputInfo = input.Split(' ').ToArray();

                string serialNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item(itemName, itemPrice);
                //item.Name = itemName;
                //item.Price = itemPrice;

                Box box = new Box(serialNumber, item, itemQuantity);
                //box.SerialNumber = serialNumber;
                //box.Item = item;
                //box.ItemQuantity = itemQuantity;

                boxes.Add(box);

            }

            foreach (Box currentBox in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} – ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:F2}");
            }


        }
    }
}
