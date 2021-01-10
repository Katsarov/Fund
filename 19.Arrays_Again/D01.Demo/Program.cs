using System;
using System.Collections.Generic;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Искаме да отпечатаме числата от 0 до 100 през 5

            int n = int.Parse(Console.ReadLine());
            int[] ages = new int[n/5 + 1];

            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = i * 5;
            }

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {ages[i]}");
            }

            Console.WriteLine($"The array length is: {ages.Length}");
        }
    }
}
