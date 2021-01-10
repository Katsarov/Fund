using System;
using System.Linq;

namespace E04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives an array and number of rotations you have to perform (first element goes at the end) Print the resulting array.

            string[] numbers = Console.ReadLine().Split().ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    string temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
