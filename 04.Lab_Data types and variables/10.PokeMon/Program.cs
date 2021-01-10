using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());

            int targetCount = 0;
            int originalNValue = n;

            while (n >= m)
            {
                if (n == originalNValue / 2 && y > 0)
                {
                    n /= y;

                    if (n < m)
                    {
                        break;
                    }
                }

                n -= m;
                targetCount++;
            }

            Console.WriteLine(n);
            Console.WriteLine(targetCount);
        }
    }
}
