using System;
using System.Collections.Generic;
using System.Text;

namespace D05._1.ClassProperties
{
    class Dog
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
            Console.WriteLine($"Name -> {Name} Age -> {Age}");
        }
    }
}
