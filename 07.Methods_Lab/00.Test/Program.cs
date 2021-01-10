using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintTriangle(count);
        }

        static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);  
        }

        static void PrintTopPart(int num)
        {
            for (int counter = 1; counter <= num; counter++)
            {
                PrintRow(counter);
            }
        }

        static void PrintBottomPart(int num)
        {
            for (int counter = num - 1; counter >= 1; counter--)
            {
                PrintRow(counter);
            }
        }

        static void PrintRow(int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
