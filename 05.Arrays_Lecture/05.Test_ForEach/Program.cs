using System;

namespace _05.Test_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, };

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
