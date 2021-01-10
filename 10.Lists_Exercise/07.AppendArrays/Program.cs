using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> appendArrays = new List<string>();

            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray(); // Условие 1

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] splitedInput = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();  // Условие 2

                for (int j = 0; j < splitedInput.Length; j++)
                {
                    appendArrays.Add(splitedInput[j]);
                }
            }

            Console.WriteLine(string.Join(" ", appendArrays));
        }
    }
}
