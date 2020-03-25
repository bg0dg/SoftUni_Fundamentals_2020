using System;
using System.Collections.Generic;
using System.Text;

namespace lab_07._Store_Boxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
