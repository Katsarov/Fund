using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] train = new int[count];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                train[i] = number;
                sum += number;
            }

            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
