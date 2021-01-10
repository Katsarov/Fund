using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // прочитаме си стринговете от двата масива
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            string result = string.Empty;

            // по условие трябва да сравняваме думите от втория масив с думите от първия, затова първо въртим втория масив
            foreach (var word1 in arrayTwo)
            {
                foreach (var word2 in arrayOne)
                {
                    if (word1 == word2)
                    {
                        result += word1 + " ";
                    }

                }

            }

            Console.WriteLine(result);
        }
    }
}
