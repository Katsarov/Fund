﻿using System;

namespace E01.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i] + "");
                }
            }
            Console.WriteLine();
        }
    }
}
