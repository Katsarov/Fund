using System;

namespace D04.Demo_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Sum(first, second);
        }

        static void Sum(int one, int two)
        {
            Console.WriteLine(one + two);
        }
    }
}
