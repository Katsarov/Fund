using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //List<string> products = new List<string>();

            //for (int i = 0; i < n; i++)
            //{
            //    string product = Console.ReadLine();
            //    products.Add(product);
            //}

            //products.Sort();

            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {products[i]}");
            //}

            // ------------------------------------------------------------------------------------------
            // Сортиране на списък с имена от масив
            //string[] names = new string[] { "Ivan", "Peter", "Andrey" };

            //var ordered = names.OrderByDescending(x => x).ToArray();

            //for (int i = 0; i < ordered.Length; i++)
            //{
            //    Console.WriteLine(ordered[i]);
            //}

            // ------------------------------------------------------------------------------------------
            // Сортиране на списък с имена от лист
            //List<string> names = new List<string> { "Ivan", "Peter", "Andrey" };

            //names.Sort();

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //List<int> numbers = new List<int> { 1, 8, 4, 33, 9, 15 };

            //numbers.Reverse();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //List<int> numbers = new List<int> { 1, 8, 4, 33, 9, 15 };
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));

            //List<int> numbers = new List<int> { 1, 8, 4, 33, 9, 15 };

            //var ordered = numbers.OrderByDescending(x => x).ToList();

            //for (int i = 0; i < ordered.Count; i++)
            //{
            //    Console.WriteLine(ordered[i]);
            //}

            //List<int> numbers = new List<int> { 1, 8, 4, 33, 9, 15 };

            //numbers.Sort();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
        }
    }
}
