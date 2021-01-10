using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(numberOne, sign, numberTwo));

        }

        static double Calculate(int first, string @operator, int second)
        {
            double result = 0;
            switch (@operator)
            {

                case "+":
                    result = first + second;
                    break;

                case "-":
                    result = first - second;
                    break;

                case "/":
                    result = first / second;
                    break;

                case "*":
                    result = first * second;
                    break;
            }
            return result;
        }
    }
}
