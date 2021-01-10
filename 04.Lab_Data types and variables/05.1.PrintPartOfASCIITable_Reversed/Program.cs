using System;

namespace _05._1.PrintPartOfASCIITable_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int step = 1;
            int number = start;

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
                step = -1;
            }

            string result = string.Empty;

            for (int i = start; i <= end; i += 1)
            {
                result += (char)number + " ";
                number += step;
            }

            Console.WriteLine(result);
        }
    }
}
