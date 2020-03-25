using System;
using System.Collections.Generic;
using System.Text;

namespace lab_07._Store_Boxes
{
    class Box
    {
        //Serial Number, Item, Item Quantity and Price for a Box.

        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        //public decimal PriceForABox
        //    => Item.Price * ItemQuantity; //calculated property. This is a short way for the code below:

        public decimal PriceForABox 
        {
            get
            {
                return PriceForABox = Item.Price * ItemQuantity;
            }
            set
            {
        
            }
        }

    }
}
