using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double extract = MathPowerResult(n, pow);
            Console.WriteLine(extract);
        }

        static double MathPowerResult(double a, double b)
        {
            double result = 1.0;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
