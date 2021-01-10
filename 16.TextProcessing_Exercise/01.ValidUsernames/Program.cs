using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // Правим си един лист, в който ще добавяме валидните usernames
            var validUsernames = new List<string>();

            // Преминаваме през всички имена от входа
            for (int i = 0; i < input.Length; i++)
            {
                // Проверяваме за всеки един инпут дали е валиден
                string current = input[i];

                // Проверяваме първо дължината дали отговаря
                if (current.Length >= 3 && current.Length <= 16)
                {
                    // преди фор цикъла си правим булева променлива, като в началото казваме, че username is valid
                    bool isValid = true;

                    // Правим си един фор цикъл, който да обходи елементите на сегашната дума
                    for (int j = 0; j < current.Length; j++)
                    {
                        // Тук проверяваме дали има невалиден символ
                        // Ако нашия символ НЕ Е буква или число, или тире или долна черта
                        if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                        {
                            // Ако влезем тук, значи сме попаднали на невалиден символ

                            isValid = false;

                            // Идеята на булевата променлива е, че ако сме срещнали невалиден символ, влизаме в тази if проверка и булевата променлива става false, поради което не минаваме по-надолу в кода, а се връщаме за нова проверка
                        }
                    }

                    // Ако сме прескочили if проверката, значи username е валидна и я добавяме в листа 
                    if (isValid)
                    {
                        validUsernames.Add(current);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}
