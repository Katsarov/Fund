using System;

namespace D03.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(3, 15);
            Console.WriteLine();
            PrintNumbers(22, 30);
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
