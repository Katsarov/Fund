using System;
using System.Numerics;

namespace _11._1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxResult = 0;
            short maxSnowballSnow = 0;
            short maxSnowballTime = 0;
            short maxSnowballQuality = 0;


            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

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
