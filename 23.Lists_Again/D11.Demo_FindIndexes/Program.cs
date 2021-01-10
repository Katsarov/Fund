using System;
using System.Linq;

namespace D11.Demo_FindIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();
            string toFind = Console.ReadLine();

            int index = 0;
            while (index != -1)
            {
                index = list.IndexOf(toFind, index + 1);
                if (index == -1)
                {
                    break;
                }

                Console.WriteLine($"{toFind} found at index {index}");
            }
        }
    }
}
