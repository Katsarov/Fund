using System;
using System.Collections.Generic;
using System.Linq;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<double>> products = new Dictionary<int, List<double>>();
            products.Add(1, new List<double>() { 5.60, 7.20, 3.90, 4.50 });

            var product = products[1].OrderBy(x => x).ToList();

            //Console.WriteLine(string.Join(" ", product));

            foreach (var item in product)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
