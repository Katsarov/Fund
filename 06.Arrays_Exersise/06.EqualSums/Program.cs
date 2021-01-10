using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //1. Go through each element
            //2. Sum all elements on its left
            //3. Sum all elements on its right
            //4. If they are equal -> break

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
