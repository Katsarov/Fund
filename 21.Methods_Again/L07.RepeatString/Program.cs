using System;
using System.Text;

namespace L07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives a string and a repeat count n (integer). The method should return a new string (the old one repeated n times)

            string input = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            string output = RepeatString(input, n);
            Console.WriteLine(output);
        }

        static string RepeatString(string inputString, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(inputString);
            }

            string result = sb.ToString();
            return result;
        }

        // Вариант 2 - но е много по-бавен
        //static string ConcatenateString(string inputString, int n)
        //{
        //    string input = string.Empty;

        //    for (int i = 0; i < n; i++)
        //    {
        //        input += inputString;
        //    }

        //    return input;
        //}
    }
}
