using System;
using System.Collections.Generic;
using System.Linq;

namespace D10.Demo_RemoveRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Да се махнат 4 елемента, започващи от индекс 1
            // Вход:  1 2 3 4 5 6 7
            // Изход: 1 6 7
            numbers.RemoveRange(1, 4);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
