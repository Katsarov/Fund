using System;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxResult = int.MinValue;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;
            

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = (double)Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxResult)
                {
                    maxResult = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxResult} ({maxSnowballQuality})");
        }
    }
}
