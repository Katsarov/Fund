using System;

namespace L05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculatedPrice(product, quantity);
        }

        static void CalculatedPrice(string product, int quantity)
        {
            double total = 0;
            

            if (product == "coffee")
            {
                total = 1.50 * quantity;
            }
            else if (product == "coke")
            {
                total = 1.40 * quantity;
            }
            else if (product == "water")
            {
                total = 1.00 * quantity;
            }
            else if (product == "snacks")
            {
                total = 2.00 * quantity;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
