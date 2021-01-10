using System;
using System.Collections.Generic;

namespace _06.NikuldensMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestsList = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split("-");

                if (tokens[0].Contains("Like"))
                {
                    var guest = tokens[1];
                    var meal = tokens[2];
                    if (!guestsList.ContainsKey(guest))
                    {
                        guestsList.Add(guest);
                    }
                    else
                    {
                        guest[guest].Add(meal);
                    }
                }


                command = Console.ReadLine();
            }
        }
    }
}
