using System;

namespace D08.Demo_Return
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string result = Hello("Bai Pesho");
            Console.WriteLine(result);

            Console.WriteLine(Sum(5, 6));
            double resultDiv = Division(12, 5);
            Console.WriteLine(resultDiv);
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }

        static double Division(double first, double second)
        {
            return first / second;
        }

        static string Hello(string name)
        {
            string message = $"Hello {name}. Nice to meet you!";
            return message;
        }
    }
}
