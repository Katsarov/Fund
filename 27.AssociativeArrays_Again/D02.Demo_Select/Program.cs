using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace D02.Demo_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            // Това ни прави един масив с елементите от 1 до 100
            int[] array = Enumerable.Range(0, 100).ToArray();

            var even = array.Where(x => x % 2 == 0).Select(x => x * 2).Where(x => x > 100).ToArray();

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
            

            //int[] array = Console.ReadLine().Split().Select(int.Parse).Where(x => x > 0).ToArray();

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
