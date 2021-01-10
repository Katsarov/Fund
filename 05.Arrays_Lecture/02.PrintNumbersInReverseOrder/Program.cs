using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // прочитаме число от конзолата
           

            int[] numbers = new int[n];  // създаваме си масив от числа с дължината на n

            for (int i = 0; i < n; i++)  
            {
                int number = int.Parse(Console.ReadLine());  // прочитаме всяко от тези n числа с цикъл
                numbers[i] = number;  // сетваме числото към съответния индекс
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i] + " ");  // принтираме числата от масива в обратен ред
            }
        }
    }
}
