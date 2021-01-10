using System;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", "Ivanov", 51, "ivan@ivan.bg");
            Console.WriteLine(ivan.FirstName);
            ivan.PrintPerson();
            Console.WriteLine(ivan.ToString());

            Person gosho = new Person("Georgi", "Dragnev");
            Console.WriteLine(gosho.LastName);
            gosho.PrintPerson();

            Person rado = new Person("Radoslav", "Petrov", 34);
            Console.WriteLine($"{rado.Age} {rado.LastName}");
            rado.PrintPerson();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, int age, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = eMail;
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age} {Email}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} {Email}";
        }

    }
}
