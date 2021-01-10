using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Трябва да вземем 3-те най-големи числа
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToList();

            // Прочитаме числата от конзолата, сплитваме ги. селектираме ги и ги парсваме към инт, сортираме ги ш низходящ ред, вземаме първите 3 най-големи числа и всичко това го правим на лист.

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
