using System;

namespace D04.Demo_NumbersMultipliedBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Въведете N числа и ги отпечатайте, като всяко едно число го умновите с 5

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            // Добре е винаги да разделяме четенето от отпечатването с 2 отделни цикъла!

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                numbers[i] = numbers[i] * 5;
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array [{i}] = {numbers[i]}");
            }
        }
    }
}