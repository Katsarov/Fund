using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // Извикваме си метода, като знаем, че винаги ще ни подават 2 стринга (затова в метода посочваме input[0] input[1])
            CharMultiplier(input[0], input[1]);
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        static int CharMultiplier(string first, string second)
        {
            int sum = 0;

            // Първо трпбва да определим кой стринг е с по-голяма дълвина. За целта си правим 2 променливи:
            string longest = "";
            string shortest = "";

            // За да определим кой стринг е по-дълъг, използваме проверка if
            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }

            // За да не излезем от границите на стринга, правим проверка само до по-късия стринг
            for (int i = 0; i < shortest.Length; i++)
            {
                // Няма да кастваме към int, поневе умноваваме стойностите от ASCII таблицата на тези чарактъри
                sum += shortest[i] * longest[i];
            }

            // За да обходим по-дългия стринг до края, използваме още един фор цикъл
            // Тъй като вече сме обходили до дълвината на по-късия стринг, то започваме този цикъл от там
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
