using System;

namespace _07._1.WaterOverflow_Alen
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = 255;
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());

                if (capacity + litters <= maxCapacity)
                {
                    capacity += litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(capacity);
        }
    }
}
