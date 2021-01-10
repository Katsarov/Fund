using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                var studentInfo = Console.ReadLine().Split().ToArray();

                //Правим си нов студент за всеки един студент с неговите данни
                Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));

                students.Add(student);  // По този начин си добавяме в листа настоящия студент, и така за всеки един
            }

            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;  //Това конкретно име е равно на първата инстанция
            this.LastName = lastName;  //Това конкретно име е равно на втората инстанция
            this.Grade = grade;  //Тази конкретна оценка я присвояваме на третата инстанция
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
