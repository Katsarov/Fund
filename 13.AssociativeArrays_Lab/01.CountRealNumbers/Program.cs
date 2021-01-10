using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Типична задача за речник: колко пъти се среща нещо някъде
            // Прочитаме си входа, който е масив от стрингове, сплитваме ги, парсваме ги към инт и ги слагаме в масив
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            // Създаваме си сортиран речник, който е с ключ double и със стойност int. Ключа са числата от входа, а стойността е броя пъти, които всяко число се среща в този речник.
            var sortedDictionary = new SortedDictionary<double, int>();

            // Прочитаме всяко едно число
            foreach (double number in numbers)
            {
                //проверка дали ключа го има
                //ако го няма -> го добавяме
                //ако го има -> заместваме

                if (sortedDictionary.ContainsKey(number))
                {
                    // ако го имаме този ключ и го срещнем отново, му казваме: вземи му value (стойността) и я увеличи с 1
                    
                    sortedDictionary[number]++;   // достъпваме value по ключа
                }
                else
                {
                    // ако го няма този ключ, го добави и сложи като брой срещания (стойност) 1
                    sortedDictionary.Add(number, 1);
                }
            }

            // Сега вече ще отпечатаме
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
