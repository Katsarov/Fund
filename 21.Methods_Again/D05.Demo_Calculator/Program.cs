using System;

namespace D05.Demo_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            Calculator(first, second, sign);
        }

        static void Calculator(double firstNum, double secondNum, string sign)
        {
            double result = 0;
            if (sign == "+")
            {
                result = firstNum + secondNum;
            }
            if (sign == "/")
            {
                result = firstNum / secondNum;
            }
            if (sign == "*")
            {
                result = firstNum * secondNum;
            }
            if (sign == "-")
            {
                result = firstNum - secondNum;
            }

            Console.WriteLine(result);
        }
    }
}
