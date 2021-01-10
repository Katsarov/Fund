using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (action == "multiply")
            {
                Multiplication(num1, num2);
            }

            else if (action == "divide")
            {
                Division(num1, num2);
            }

            else if (action == "add")
            {
                Addition(num1, num2);
            }
            else if (action == "subtract")
            {
                Subtraction(num1, num2);
            }
            
        }

        static void Multiplication(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        static void Division(double a, double b)
        {
            Console.WriteLine(a / b);
        }

        static void Addition(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtraction(double a, double b)
        {
            Console.WriteLine(a - b);
        }
    }
}
