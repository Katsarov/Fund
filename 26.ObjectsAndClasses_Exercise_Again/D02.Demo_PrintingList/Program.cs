using System;
using System.Collections.Generic;

namespace D02.Demo_PrintingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Peter", "Petrov", 34);
            Person gosho = new Person("George", "Terziev", 51);
            Person misho = new Person("Mihael", "Leviev", 17);

            List<Person> people = new List<Person>();
            people.Add(pesho);
            people.Add(gosho);
            people.Add(misho);

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age}";
        }
    }
}
