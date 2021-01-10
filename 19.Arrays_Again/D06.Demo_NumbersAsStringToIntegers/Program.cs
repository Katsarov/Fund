using System;
using System.Linq;

namespace D06.Demo_NumbersAsStringToIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //// Правим си масив със стрингове и го сплитваме по празно нясто
            //string[] numsAsString = input.Split(new char[] { ' ', ',', '!'});

            //// Правим си масив с числа с големината на броя на елементите в масива от стрингове
            //int[] numbers = new int[numsAsString.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    // Тук вече парсваме текущия елемент, който е стринг към инт, т.е. ако имаме стринга "1" да стане на числото 1.
            //    numbers[i] = int.Parse(numsAsString[i]);
            //}

            // Можем да избегнем целия код горе като използваме функцията .Select(int.Parse).ToString();
            int[] numbers = input.Split().Select(int.Parse).ToArray();

            // Отпечатваме
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array [{i}] = {numbers[i]}");
            }
        }
    }
}
