using System;
using System.Collections.Generic;

namespace _0.DemoPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отпечатване на лист от обекти

            Person first = new Person();
            Person second = new Person();
            Person third = new Person();

            // Искаме да отпечатаме лист от обекти

            List<Person> people = new List<Person>();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }

    public class Person
    {
        // Конкретния обект трябва да си има тук метод .ToString
        public override string ToString()
        {
            return $"тук посочваме пропъртитата на обекта, които да се отпечатат";
        }


    }
}
