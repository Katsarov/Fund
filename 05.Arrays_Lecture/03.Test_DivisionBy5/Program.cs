using System;

namespace _03.Test_DivisionBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()) * 5;  // прочитаме число от конзолата и го умножаваме с 5
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = numbers[i] * 5;  // умноваваме всяко число с 5
            //}

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {numbers[i]}");  //отпечтваме резултатите
            }
        }
    }
}
