using System;
using System.Linq;

namespace D02.Demo_SelectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            // Да се умнови всеки един елемент с 5

            int[] arrayByFive = array.Select(x => x * 5).ToArray();

            Console.WriteLine(string.Join(" ", arrayByFive));
        }

    }
}
