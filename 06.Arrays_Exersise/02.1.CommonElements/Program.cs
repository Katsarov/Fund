using System;

namespace _02._1.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            string result = string.Empty;

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    if (arrayTwo[i] == arrayOne[j])
                    {
                        result += arrayTwo[i] + " ";
                    }

                }

            }

            Console.WriteLine(result);
        }
    }
}
