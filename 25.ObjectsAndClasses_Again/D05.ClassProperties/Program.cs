using System;

namespace D05.ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pesho = new Dog("Pesho", 51);
            pesho.PrintDog();

            Dog gosho = new Dog("Gosho");
            gosho.PrintDog();

            Dog stray = new Dog();
            stray.PrintDog();
        }
    }

    public class Dog
    {
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Dog(string name)
        {
            this.Name = name;
        }

        public Dog()
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

        public void PrintDog()
        {
            Console.WriteLine($"Name -> {Name} Age -> {Age}");
        }
    }
}
