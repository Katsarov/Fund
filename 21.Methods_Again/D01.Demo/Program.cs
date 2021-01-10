using System;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEvenNumbers();
        }

        static void PrintEvenNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
