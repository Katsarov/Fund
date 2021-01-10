using System;

namespace D02.Demo_StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student();
            pesho.name = "Pesho";
            pesho.age = 15;
            pesho.skills = new string[] { "football", "basketball", "loto" };

            Student gosho = new Student();
            gosho.name = "George";
            gosho.age = 36;

            PrintStudent(pesho);
            PrintStudent(gosho);
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"Name -> {student.name} => Age -> {student.age}");
        }
    }
}
