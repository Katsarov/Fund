using System;

namespace D06.Demo_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumsBetween(25);
        }

        static void PrintNumsBetween(int start = 0, int end = 30)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
