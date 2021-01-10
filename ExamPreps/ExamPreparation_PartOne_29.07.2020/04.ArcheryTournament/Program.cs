using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Правим си дикшинъри, стринг е името на града, и след това лист с интове за население и златото
            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                // Сплитваме входа по "||" и след това вземаме за всяко едно
                var splitted = input.Split("||");
                string name = splitted[0];
                int people = int.Parse(splitted[1]);
                int gold = int.Parse(splitted[2]);

                if (towns.ContainsKey(name))
                {
                    towns[name][0] += people;
                    towns[name][1] += gold;
                }

                else
                {
                    // Добавяме си града, населението и златото в дикшинърито
                    towns.Add(name, new List<int>() { people, gold });
                }
                

                input = Console.ReadLine();
            }

            // Прочитаме си и вротия инпут (след командата "Sale" от първич инпут)
            input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("Plunder"))
                {
                    var splitted = input.Split("=>");
                    string town = splitted[1];
                    int people = int.Parse(splitted[2]);
                    int gold = int.Parse(splitted[3]);

                    // Намаляме първо стойността на листа с населението, и след това със златото
                    towns[town][0] -= people;
                    towns[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (towns[town][0] <= 0 || towns[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        towns.Remove(town);
                    }
                }

                if (input.Contains("Prosper"))
                {
                    var splitted = input.Split("=>");
                    string town = splitted[1];
                    int gold = int.Parse(splitted[2]);

                    // Намаляме първо стойността на листа с населението, и след това със златото
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        towns[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town][1]} gold.");
                    }
                }

                input = Console.ReadLine();
            }

            // Накрая го сортираме. Първо в низходящ ред по злато[1], след това във възходящ ред по името
            towns = towns.OrderByDescending(t => t.Value[1]).ThenBy(t => t.Key).ToDictionary(t => t.Key, t => t.Value);

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
            foreach (var town in towns)
            {
                Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
            }
        }
    }
}
