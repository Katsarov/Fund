using System;
using System.Collections.Generic;
using System.Linq;

namespace D09.Demo_RemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Премахва всички цифри 5
            // Вход: 1 2 3 5 4 5 6 7 8 5
            // Изход: 1 2 3 4 6 7 8 
            //numbers.RemoveAll(i => i == 5);
            //Console.WriteLine(string.Join(" ", numbers));

            // Премахва всички четни числа
            // Вход: 1 2 3 4 5 6 7 8 
            // Изход: 1 3 5 7 
            //numbers.RemoveAll(i => i % 2 == 0);
            //Console.WriteLine(string.Join(" ", numbers));

            // Премахва всички четни числа и такива, които се делят на 3
            // Вход: 1 2 3 4 5 6 7 8 9 10 11
            // Изход: 1 5 7 11
            numbers.RemoveAll(i => i % 2 == 0 || i % 3 == 0);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
