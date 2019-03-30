using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClasses_Lab___07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> Boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] boxInfo = input.Split(' ');

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                double itemPrice = double.Parse(boxInfo[3]);
                
                double priceOfTheBox = itemQuantity * itemPrice;

                Box newBox = new Box();

                newBox.SerialNumber = serialNumber;
                newBox.Item.Name = itemName;
                newBox.Item.Price = itemPrice;
                newBox.ItemQuantity = itemQuantity;
                newBox.PriceForABox = priceOfTheBox;

                Boxes.Add(newBox);
                
            }

            Boxes = Boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (var box in Boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine( $"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine( $"-- ${box.PriceForABox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
}
