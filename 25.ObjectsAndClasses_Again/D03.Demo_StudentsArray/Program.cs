using System;
using System.Collections.Generic;

namespace D03.Demo_StudentsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // В случая ще прочетем масив от студенти
            Console.WriteLine("How many students in SoftUni?");
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            //  Причитаме всеки един студент и го добавяме в листа
            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            // Принтираме шсеки от студентите в листа
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
            Console.WriteLine($"Name -> {student.name} <<>> Age -> {student.age} <<>> Skills -> {string.Join(" : ", student.skills)}");
        }
    }
}
