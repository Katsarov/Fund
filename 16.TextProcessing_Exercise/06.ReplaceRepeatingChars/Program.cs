using System;
using System.Collections.Generic;
using System.Linq;


namespace DictExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
