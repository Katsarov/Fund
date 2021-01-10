using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Student
    {
        public string Name;
        public int Age;
        public string[] Skills;

        public void AgeStudent()
        {
            this.Age++;  // Увеличи възрастта на текущия студент. Тук този Age ще сочи към локалната инстанция Age (ред 10).
        }

        public void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name -> {student.Name} -> age -> {student.Age} -> skills -> {string.Join(",", student.Skills)}");
        }
    }
}
