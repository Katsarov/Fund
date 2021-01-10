using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;

                if (sum < 255)
                {
                    continue;
                }
                else if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters;
                }
                else if(sum == liters)
                {
                    Console.WriteLine(liters);
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
