using System;

namespace _02.RepeatStrings_Dakov
{
    class Program
    {
        static void Main(string[] args)
        {
            // Прочитаме си входа
            string[] words = Console.ReadLine().Split();

            // Въртим цикъл до дължината на стринга (примерно: hi abc bom). Първо ще проверим думата hi
            for (int i = 0; i < words.Length; i++)
            {
                // Въртим цикъл за всяка буква от думата (hi -> hihi). Тук цикъла ще го завъртим 2 пъти
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
