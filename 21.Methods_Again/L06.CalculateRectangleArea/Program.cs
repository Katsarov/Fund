using System;

namespace L06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //int result = GetArea(a, b);
            Console.WriteLine(GetArea(a, b));
        }

        static int GetArea(int shortSide, int longSide)
        {
            return shortSide * longSide;
        }
    }
}
