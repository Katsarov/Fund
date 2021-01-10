using System;
using System.Collections.Generic;
using System.Text;

namespace D05.StaticMethods
{
    public class Student
    {
        public string Name;
        public int Age;
        public string[] Skills;

        public void AgeStudent()
        {
            this.Age++;
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"Name -> {student.Name} <<>> Age -> {student.Age} <<>> Skills -> {string.Join(" : ", student.Skills)}");
        }
    }
}
