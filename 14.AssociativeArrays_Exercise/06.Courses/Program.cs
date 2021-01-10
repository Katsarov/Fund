using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                // Прочитаме си входа
                string courseName = input.Split(" : ")[0];
                string studentName = input.Split(" : ")[1];


                // Сега си пълним нашия речник
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            // Сега сортираме:
            // 1. списъка в низходящ ред по брой студенти

            foreach (var pair in courses.OrderByDescending(course => course.Value.Count))
                // Искам да ми вземеш всяка една двойка (pair) в този речник, който е сортиран в низходящ ред (.OrderByDescending), като всеки един курс (course) искам да го сортираш спрямо другите (=>), като вземеш броя на курсистите (.Count), които се намират в списъка (course.Value)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value.Count);

                // 2. във възходящ ред по имената на студентите
                List<string> students = pair.Value;
                students.Sort();

                // Сега принтираме - всеки един от курсовете с техните имена и общия брой студенти

                foreach (string student in students)
                {
                    Console.WriteLine("-- " + student);
                }
            }
        }
    }
}
