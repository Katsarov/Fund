using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int current = i;
                int sum = 0;
                while (current > 0)
                {
                    sum += current % 10;  // така вземаме всяка една последна цифра
                    current /= 10;
                }

                bool isSpecial = false;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
