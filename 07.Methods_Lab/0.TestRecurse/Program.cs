using System;
using System.Security.Cryptography;

namespace _0.TestRecurse
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEvenNumbersTo100();
        }

        static void PrintEvenNumbersTo100()
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
