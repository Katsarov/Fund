using System;

namespace ExampleDog

{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pesho = new Dog("Pesho", 51);
            pesho.PrintDog();
            Dog sharo = new Dog("Sharo", 23);
            sharo.PrintDog();
        }
    }

    public class Dog
    {
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public void PrintDog()
        {
            Console.WriteLine($"Name: {Name} -> Age: {Age}");
        }
    }

    
}
