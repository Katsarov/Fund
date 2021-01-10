using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] specNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = specNumber[0];
            int power = specNumber[1];

            int bombIndex = numbers.IndexOf(bombNumber);  //  това е индекса на първата срещната бомба

            while (bombIndex != -1)  // ако имаме само 1 бомба, след като я махне ще върне -1 и ще излезем от цикъла
            {
                int startIndex = bombIndex - power;
                int endIndex = bombIndex + power;

                if (startIndex < 0)  // ако сме излезли от долната граница
                {
                    startIndex = 0;  // да се върнем на първия елемент
                }
                if (endIndex > numbers.Count - 1)  // ако сме излезли от горнатаната граница
                {
                    endIndex = numbers.Count - 1;  // да се върнем на последния елемент
                }
                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);  // махаме рейнджа

                bombIndex = numbers.IndexOf(bombNumber);  // вземи индекса на следващата бомба
            }

            Console.WriteLine(string.Join(" ", numbers.Sum()));

            //Вариант 2 за сумирането на елементите

            //int sum = 0;
            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(string.Join(" ", sum));
        }
    }
}
