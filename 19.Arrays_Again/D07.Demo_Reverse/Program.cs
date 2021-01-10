using System;

namespace D07.Demo_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                // Прочитаме всеки един елемент и го парсваме към число
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[array.Length - i - 1] + " ");
            }
            Console.WriteLine();
        }
    }
}
