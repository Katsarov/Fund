using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(a, b);
            Console.WriteLine(area);
            
        }

        static double GetRectangleArea(double height, double width)
        {
            return height * width;
        }
    }
}
