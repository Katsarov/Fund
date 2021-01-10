using System;

namespace L04.PrintingTriangles_Dakov
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNumbersFrom1(i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                PrintNumbersFrom1(i);
            }

        }

        static void PrintNumbersFrom1(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
