using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.StudentsAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            //Правим си нов речник, в който ще държим името на студента и средния успех от всичките му оценки
            var averageResults = new Dictionary<string, double>();
            foreach (var item in studentGrades)
            {
                averageResults.Add(item.Key, item.Value.Average());
            }

            // Сортираме си речника според зададените условия
            averageResults = averageResults.Where(x => x.Value >= 4.5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, z => z.Value);

            foreach (var item in averageResults)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
