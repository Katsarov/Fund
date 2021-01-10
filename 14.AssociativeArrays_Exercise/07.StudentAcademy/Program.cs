using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правим си речник, ш който за Key ще бъде името на студента, а за Value ще си направим лист от дабъли, в който ще съхраняшаме оценките му.
            var studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());  // колко студенти ще бъдат въведени

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))  // Ако този студент го няма в списъка, трябва да го добавим
                {
                    studentGrades.Add(name, new List<double>());  // Срещу това име (name) искаме да стои този лист с оценки (който за сега е празен)  и трябва сегашната оценка (grade) да я словим в листа с оценки.

                    studentGrades[name].Add(grade);
                    // Чрез studentGrades[name] ние достъпваме празния лист List<Double>(). В него сега записваме оценката (grade).

                }
                else
                {
                    studentGrades[name].Add(grade);  // Ако студента вече го има, вземаме листа до момента и добавяме нова оценка
                }
            }

            // Излизайки от цикъла, ние вече имаме име на студент и лист с неговите оценки. 
            // Целта ни обаче не е да имаме студент и лист с оценки, а да имаме студент и неговата средна оценка. За целта си правим нов речник.

            var averageResults = new Dictionary<string, double>();

            // Минаваме първо през стария речник, вземаме всяка една двойка от стария речник
            foreach (var pair in studentGrades)
            {
                // Добави в новия речник настоящата двойка, вземи Key и вземи на Value средната оценка 
                averageResults.Add(pair.Key, pair.Value.Average());

                // Какво направихме:
                // 1. Създадохме си един нов речник (averageResults), в който си съхраняваме името на студента и средната му оценка
                // 2. Обходихме всяка една двойка от стария речник, като в новия сложихме:
                //  2.1. ключа на тази двойка (pair.Key)
                //  2.2. взимаме листа с оценките на студента (pair.Value) и даваме средно аритметична оценка с .Average();
            }

            // Сега искаме:
            // 1. да филтрираме и вземем всицки с оценка >= 4.50
            // 2. да сортираме по средна оценка

            foreach (var pair in averageResults.Where(student => student.Value >= 4.50).OrderByDescending(st => st.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }

        }
    }
}
