using System;

namespace L04.PrintingTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangleTop(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
            Console.WriteLine();
            }
        }
        static void PrintTriangleBottom(int number)
        {
            for (int i = number - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle(int num)
        {
            PrintTriangleTop(num);
            PrintTriangleBottom(num);
        }
    }
}
