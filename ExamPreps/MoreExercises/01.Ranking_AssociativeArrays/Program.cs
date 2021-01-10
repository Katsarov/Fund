using System;
using System.Collections.Generic;
using System.Linq;


namespace DictExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> partOne = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> partTwo = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] command = input.Split(":");

                string contest = command[0];

                string password = command[1];

                if (!partOne.ContainsKey(contest))
                {
                    partOne.Add(contest, password);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] command = input.Split("=>");

                string contest = command[0];
                string password = command[1];
                string username = command[2];
                int points = int.Parse(command[3]);

                if (partOne.ContainsKey(contest) && password == partOne[contest])
                {
                    if (!partTwo.ContainsKey(username))
                    {
                        partTwo.Add(username, new Dictionary<string, int>());

                    }
                    if (!partTwo[username].ContainsKey(contest))
                    {
                        partTwo[username].Add(contest, points);
                    }
                    if (partTwo[username][contest] < points)
                    {
                        partTwo[username][contest] = points;
                    }
                }
            }

            Dictionary<string, int> bestStudent = new Dictionary<string, int>();

            foreach (var username in partTwo)
            {
                bestStudent.Add(username.Key, username.Value.Values.Sum());
            }

            int bestStudentPoints = bestStudent.Values.Max();

            foreach (var beststudent in bestStudent)
            {
                if (beststudent.Value == bestStudentPoints)
                {
                    Console.WriteLine($"Best candidate is {beststudent.Key} with total {beststudent.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");

            foreach (var students in partTwo.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{students.Key}");

                foreach (var courses in students.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {courses.Key} -> {courses.Value}");
                }
            }
        }
    }
}
