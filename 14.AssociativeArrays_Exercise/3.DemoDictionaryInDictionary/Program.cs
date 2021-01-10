using System;
using System.Collections.Generic;

namespace _3.DemoNestedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правим си речник с имена на студенти, и в него имаме предмети с оценки
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            // Прочитаме името на студента
            string[] studentNames = Console.ReadLine().Split();

            // za vseki student si pravim nov reqnik, v kojto ]e dobav[me predmet i ocenka
            foreach (var item in studentNames)
            {
                students.Add(item, new Dictionary<string, int>());
            }


            students["pesho"].Add("biology", 5);
            students["gosho"].Add("biology", 3);
            students["tosho"].Add("biology", 4);
            students["pesho"].Add("chemie", 6);

            // за да отпечатаме това цялото:
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} --> ");
                foreach (var grades in student.Value)   // student.Value ни е целия речник
                {
                    Console.WriteLine($"{grades.Key} : {grades.Value}");
                }
            }

            // Вход: pesho gosho tosho
            // Резултат:
            // pesho -->
            // biology : 5
            // chemie : 6
            // gosho -->
            // biology : 3
            // tosho -->
            // biology : 4
        }
    }
}
