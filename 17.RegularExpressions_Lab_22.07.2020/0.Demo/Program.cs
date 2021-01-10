using System;
using System.Text.RegularExpressions;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да разпечатаме всички имена
            string pattern = @"([A-Z][a-z]+) ([A-Z][a-z]+)";

            // Сега ще използваме класа Regex, като подаваме pattern-a като аргумент в скобите
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            Console.WriteLine(regex.IsMatch(input));
            // IsMatch ще провери дали това, което сме въвели като input има поне 1 съвпадение спрямо нашия pattern. Връща TRUE или FALSE

            //Console.WriteLine(regex.Match(input).Value);
            // Match(input).Value ни връща първото име и фамилия, които е срещнало

            //Console.WriteLine(regex.Matches(input).Count);

            // Сега мовем да използваме цикъл foreach
            // Изваждаме си matches  в отделна променлива като лист и ги отпечатваме

            //var matches = regex.Matches(input);
            //foreach  (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                // Отпечатваме си двете групи: Име: ... Фамилия:......
                Console.WriteLine($"Name: {match.Groups[1].Value} Family: {match.Groups[2].Value}");
            }

        }
    }
}
