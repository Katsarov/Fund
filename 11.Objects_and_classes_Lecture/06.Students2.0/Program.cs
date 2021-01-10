using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName, age);
                }

                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        public static Student GetStudent(List<Student> list, string firstName, string lastName, int age)
        {
            Student existingStudent = null;
            foreach (Student student in list)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }

            return existingStudent;
        }

    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }


    }
}

