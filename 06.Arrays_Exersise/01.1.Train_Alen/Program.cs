using System;
using System.Linq;

namespace _01._1.Train_Alen
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(array.Sum());
        }
    }
}
