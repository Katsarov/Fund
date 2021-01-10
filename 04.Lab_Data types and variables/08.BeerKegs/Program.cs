using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double biggestKeg = int.MinValue;
            string biggestModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;  // Math.Pow(radius, 2) = (radius * radius)

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestModel = model;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
