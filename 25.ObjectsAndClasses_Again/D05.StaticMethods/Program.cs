using System;

namespace D05.StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Pesho",
                Age = 15,
                Skills = new string[0]
            };

            //Student.PrintStudent(student);

            Console.WriteLine(student.Age);
            student.AgeStudent();
            student.AgeStudent();
            student.AgeStudent();
            Console.WriteLine(student.Age);
        }
    }
}
