using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            // Сега искаме да вземем последния елемент на сплитнатия масив. Достъпваме го чрез индекса му.
            var file = input[input.Length - 1].Split(".");

            string name = file[0];
            string extention = file[1];

            Console.WriteLine($"File name: " + name);
            Console.WriteLine($"File extension: " + extention);
        }
    }
}
