using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Input number of products
            int n = int.Parse(Console.ReadLine());

            // 2. Read each product and add it to the list
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            // 3. Sort the list
            products.Sort();

            // 4. Print sorted and numbered list
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
