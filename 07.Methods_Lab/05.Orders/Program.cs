using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }

        static void TotalPrice(string good, int number)
        {
            double result = 0.0;

            if (good == "coffee")
            {
                result = number * 1.5;
            }
            if (good == "water")
            {
                result = number * 1.0;
            }
            if (good == "coke")
            {
                result = number * 1.4;
            }
            if (good == "snacks")
            {
                result = number * 2.0;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
