using System;

namespace L08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that calculates and returns the value of a number raised to a given power:

            double number = double.Parse(Console.ReadLine());

            double power = double.Parse(Console.ReadLine());

            double result = PowResult(number, power);
            Console.WriteLine(result);
        }

        //static double PowResult(double n, double pow)
        //{
        //    double output = Math.Pow(n, pow);
        //    return output;
        //}

        // Вариант 2
        static double PowResult(double number, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        
    }
}
