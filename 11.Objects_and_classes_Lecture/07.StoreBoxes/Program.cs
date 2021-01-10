using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Item> item = new List<Item>();
            List<Box> box = new List<Box>();

            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();


                command = Console.ReadLine();
            }
        }
    }

    class Item
    {
        public string Name { get; set; }

        public int Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }
    }

    class Catalogue
    {
        List<Item> items { get; set; }
        List<Box> boxes { get; set; }
    }
}
