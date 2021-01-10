using System;

namespace D11.Demo_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            foreach (int currentNumber in numbers)
            {
                //Console.WriteLine(currentNumber);
                Console.Write($"{currentNumber} ");
            }
        }
    }
}
