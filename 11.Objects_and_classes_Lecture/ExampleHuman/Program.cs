using System;

namespace ExampleHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine(); //прочитаме от конзолата собственото име 
            string lastName = Console.ReadLine();  //прочитаме от конзолата фамилното име 
            var human = new Human(firstName, lastName);

            Console.WriteLine(human.FullName);
        }
    }

    class Human
    {
        public Human(string firstName, string lastName) //това е конструктор
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName 
        { 
            get { return FirstName + " " + LastName; } 
        }  //тук особеното е, че сме махнали set и вече никой не може да го променя. Но ако променим пършото име или фамилията, то се променя и FullName
    }
}
