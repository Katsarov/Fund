using System;
using System.Collections.Generic;
using System.Linq;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>() { 2, 3, 4, 5, 6, 9, 12, 14 };
            
            // Отпечатваме числата, като само нечетните са умножени по 2 (използваме метод за определяне на нечетните числа)
            var oddNumbersMultiplied = numbers.Select(x => oddNums(x)).ToList();
            
            //Console.WriteLine(string.Join(Environment.NewLine, oddNumbersMultiplied));

            // Отпечатваме само числата, по-големи от 10
            var biggestNums = oddNumbersMultiplied.Where(x => x > 10).ToList();
            
            Console.WriteLine(string.Join(Environment.NewLine, biggestNums));

        }

        static int oddNums(int nums)
        {
            if (nums % 2 == 1)
            {
                return nums * 2;
            }
            return nums;
        }
    }
}
