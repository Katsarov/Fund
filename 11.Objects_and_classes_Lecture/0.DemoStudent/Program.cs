using System;
using System.Collections.Generic;

namespace _0.DemoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students have in SoftUni?");
            int n = int.Parse(Console.ReadLine());

            //Правим си един лист за студентите
            List<Student> students = new List<Student>();

            // Прочитаме един студент и го добавяме в листа
            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            // Принтираме поредния студент
            for (int i = 0; i < n; i++)
            {
                PrintStudent(students[i]);
            }

        }

        static Student ReadStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Enter name: ");
            newStudent.name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            newStudent.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills: ");
            newStudent.skills = Console.ReadLine().Split();

            return newStudent;
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name: {student.name} -> Age: {student.age} -> Skills: {string.Join(" ", student.skills)}");
        }
    }
}
