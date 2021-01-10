using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.NikulsdansMeals_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userMeal = new Dictionary<string, List<string>>();
            
            string input = Console.ReadLine();

            int totalCountOfUnlikedMeals = 0;

            while (input != "Stop")
            {
                // Input: Like-Krisi-shrimps  (Action - Name - Meal)
                string[] inputInfo = input.Split("-");

                string action = inputInfo[0];
                string name = inputInfo[1];
                string meal = inputInfo[2];

                if (action == "Like")
                {
                    // o	If the guest doesn't exist, add it to your record
                    if (!userMeal.ContainsKey(name))
                    {
                        userMeal.Add(name, new List<string>());
                    }

                    // o	If the guest already has the meal in his collection, don’t add it.
                    // o	Add the {mea1} to the {guest}’s collection of meals.
                    if (!userMeal[name].Contains(meal))
                    {
                        userMeal[name].Add(meal);
                    }
                }

                else if (action == "Unlike")
                {
                    // o	If the guest doesn’t exist, print:"{Guest} is not at the party."
                    if (!userMeal.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }

                    // o	If the guest doesn’t have the meal at the like list, print:"{Guest} doesn't have the {meal} in his/her collection."
                    else if (!userMeal[name].Contains(meal))
                    {
                        Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                    }

                    // o	Remove  the meal of the given guest’s collection and print: "{Guest} doesn't like the {meal}."
                    else
                    {
                        userMeal[name].Remove(meal);
                        Console.WriteLine($"{name} doesn't like the {meal}.");

                        // You must keep the count of unliked meals!
                        totalCountOfUnlikedMeals++;
                    }
                }

                input = Console.ReadLine();
            }

            // Output:
            // Print the guests with their liked meals sorted in descending order by each guest meals count and then by their names in ascending order
            var sortedCollection = userMeal.OrderByDescending(m => m.Value.Count).ThenBy(n => n.Key);

            // Print
            foreach (var (name, meals) in sortedCollection)
            {
                Console.WriteLine($"{name}: {string.Join(", ", meals)}");
            }

            Console.WriteLine($"Unliked meals: {totalCountOfUnlikedMeals}");
        }
    }
}
