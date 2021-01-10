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
            List<Student> list = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                list.Add(student);
                command = Console.ReadLine(); 
            }

            string filterCity = Console.ReadLine();
            foreach (Student student in list)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
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
