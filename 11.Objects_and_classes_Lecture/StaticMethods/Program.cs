using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "pesho",
                Age = 15,
                Skills = new string[0]  // стринга е с 0 елемента, т.е. няма елементи
            };

            Console.WriteLine(student.Age);  //отпечатваме възрастта на студента
            student.AgeStudent(); // извикваме метода AgeStudent() от клас Student, с който метод всеки път да увеличаваме възрастта му
            student.AgeStudent();
            student.AgeStudent();
            student.AgeStudent();
            Console.WriteLine(student.Age);

            //student.PrintStudent(student);  // 
        }
    }
}
