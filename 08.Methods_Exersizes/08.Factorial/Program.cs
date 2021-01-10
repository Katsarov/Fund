﻿using System;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = CalcFactorial(num1) / CalcFactorial(num2);
            Console.WriteLine($"{result:f2}");
        }

        static decimal CalcFactorial(int num)
        {
            // 5! = 1*2*3*4*5
            decimal factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
