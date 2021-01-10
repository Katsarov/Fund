using System;
using System.Linq;

namespace _03.TestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " ");
            }
        }
    }
}
