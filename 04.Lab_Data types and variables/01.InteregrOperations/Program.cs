﻿using System;

namespace _01.InteregrOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int divide = sum / num3;
            int product = divide * num4;

            Console.WriteLine(product);
        }
    }
}
