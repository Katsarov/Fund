using System;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person petar = new Person("Petar", "Petrov", 19, "petar@softuni.bg");  // Това е конкретния обект на класа Person. Тоша са данните на Петър.
            Person ani = new Person("Ani", "Ivanova", 23, "ani@softuni.bg");
            Person sanya = new Person();

            Console.WriteLine(petar.ToString());

            //Console.WriteLine(string.Join(Environment.NewLine, petar.FirstName, petar.LastName, petar.Age, petar.Email));

            //Console.WriteLine(string.Join(" ", petar.FirstName, petar.LastName,",", "Age = ", petar.Age,",", "E-mail = ", petar.Email));
        }
    }

    public class Person
    {
        //1. Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }  // Това е пропърти


        //2. Constructors
        public Person(string firstName, string lastName, int age, string eMail)  // това е конструктора, който инициализира данните
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = eMail;
        }

                //Можем да си направим втори конструктор, който да е празен
        public Person()
        {

        }

                //Можем да си направим третри конструктор, който да съдържа само име и фамилия
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        //3. Methods

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age = {Age}, E-mail = {Email}";
        }
    }
}
